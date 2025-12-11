using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;

namespace GK1P3.Controls
{
    [DesignerCategory("Code")]
    [Description("A control for editing piecewise linear curves with draggable control points")]
    [ToolboxItem(true)]
    public partial class CurveEditorControl : Control
    {
        private List<PointF> _controlPoints;
        private int _draggedPointIndex = -1;
        private const int PointRadius = 4;
        private const int GridSpacing = 32; // 256/8 = 32 for 8 grid lines

        public CurveEditorControl()
        {
            // Initialize with linear identity curve (0,0) -> (255,255)
            _controlPoints = new List<PointF>
            {
                new PointF(0, 255),    // Top-left (input 0 = output 255 in screen coords)
                new PointF(255, 0)     // Bottom-right (input 255 = output 0 in screen coords)
            };

            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);

            // Set default size for designer
            Size = new Size(300, 300);
            MinimumSize = new Size(150, 150);
        }

        // Convert from control point (0-255 domain/range) to screen coordinates
        private PointF ToScreen(PointF point)
        {
            float scaleX = (Width - 20) / 255f;
            float scaleY = (Height - 20) / 255f;
            return new PointF(10 + point.X * scaleX, 10 + point.Y * scaleY);
        }

        // Convert from screen coordinates to control point (0-255 domain/range)
        private PointF FromScreen(Point screen)
        {
            float scaleX = 255f / (Width - 20);
            float scaleY = 255f / (Height - 20);
            float x = Math.Max(0, Math.Min(255, (screen.X - 10) * scaleX));
            float y = Math.Max(0, Math.Min(255, (screen.Y - 10) * scaleY));
            return new PointF(x, y);
        }

        // Get output value for input (0-255) using piecewise linear interpolation
        public byte GetValue(byte input)
        {
            var sorted = _controlPoints.OrderBy(p => p.X).ToList();

            // Handle edge cases
            if (input <= sorted[0].X)
                return (byte)Math.Round(255 - sorted[0].Y);
            if (input >= sorted[^1].X)
                return (byte)Math.Round(255 - sorted[^1].Y);

            // Find the two points to interpolate between
            for (int i = 0; i < sorted.Count - 1; i++)
            {
                if (input >= sorted[i].X && input <= sorted[i + 1].X)
                {
                    float t = (input - sorted[i].X) / (sorted[i + 1].X - sorted[i].X);
                    float outputY = sorted[i].Y + t * (sorted[i + 1].Y - sorted[i].Y);
                    return (byte)Math.Round(255 - outputY); // Flip Y for output
                }
            }

            return input; // Fallback
        }

        // Generate full lookup table for filter
        public byte[] GenerateLookupTable()
        {
            var table = new byte[256];
            for (int i = 0; i < 256; i++)
            {
                table[i] = GetValue((byte)i);
            }
            return table;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw background
            g.Clear(Color.White);

            // Draw grid
            using (var gridPen = new Pen(Color.FromArgb(50, 50, 50)))
            {
                for (int i = 0; i <= 8; i++)
                {
                    float pos = 10 + i * (Width - 20) / 8f;
                    g.DrawLine(gridPen, pos, 10, pos, Height - 10);

                    pos = 10 + i * (Height - 20) / 8f;
                    g.DrawLine(gridPen, 10, pos, Width - 10, pos);
                }
            }

            // Draw diagonal reference line (identity function)
            using (var refPen = new Pen(Color.FromArgb(60, 60, 60)))
            {
                refPen.DashStyle = DashStyle.Dash;
                g.DrawLine(refPen, ToScreen(new PointF(0, 255)), ToScreen(new PointF(255, 0)));
            }

            // Draw the curve
            var sorted = _controlPoints.OrderBy(p => p.X).ToList();
            if (sorted.Count >= 2)
            {
                using (var curvePen = new Pen(Color.FromArgb(100, 150, 255), 2))
                {
                    for (int i = 0; i < sorted.Count - 1; i++)
                    {
                        g.DrawLine(curvePen, ToScreen(sorted[i]), ToScreen(sorted[i + 1]));
                    }
                }
            }

            // Draw control points
            foreach (var point in _controlPoints)
            {
                var screenPos = ToScreen(point);
                using (var brush = new SolidBrush(Color.White))
                using (var outline = new Pen(Color.FromArgb(100, 150, 255), 2))
                {
                    g.FillEllipse(brush, screenPos.X - PointRadius, screenPos.Y - PointRadius,
                                 PointRadius * 2, PointRadius * 2);
                    g.DrawEllipse(outline, screenPos.X - PointRadius, screenPos.Y - PointRadius,
                                 PointRadius * 2, PointRadius * 2);
                }
            }

            // Draw axis labels
            using (var font = new Font("Segoe UI", 8))
            using (var brush = new SolidBrush(Color.Gray))
            {
                g.DrawString("0", font, brush, 8, Height - 24);
                g.DrawString("255", font, brush, Width - 28, Height - 24);
                g.DrawString("255", font, brush, 12, 8);
                g.DrawString("0", font, brush, 12, Height - 20);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                // Check if clicking on existing point
                for (int i = 0; i < _controlPoints.Count; i++)
                {
                    var screenPos = ToScreen(_controlPoints[i]);
                    float dist = (float)Math.Sqrt(Math.Pow(e.X - screenPos.X, 2) + Math.Pow(e.Y - screenPos.Y, 2));

                    if (dist <= PointRadius + 2)
                    {
                        _draggedPointIndex = i;
                        return;
                    }
                }

                // Add new point if not clicking on existing one
                var newPoint = FromScreen(e.Location);
                _controlPoints.Add(newPoint);
                _draggedPointIndex = _controlPoints.Count - 1;
                Invalidate();
                OnCurveChanged();
            }
            else if (e.Button == MouseButtons.Right)
            {
                // Remove point on right-click (but keep at least 2 points)
                if (_controlPoints.Count > 2)
                {
                    for (int i = 0; i < _controlPoints.Count; i++)
                    {
                        var screenPos = ToScreen(_controlPoints[i]);
                        float dist = (float)Math.Sqrt(Math.Pow(e.X - screenPos.X, 2) + Math.Pow(e.Y - screenPos.Y, 2));

                        if (dist <= PointRadius + 2)
                        {
                            _controlPoints.RemoveAt(i);
                            Invalidate();
                            OnCurveChanged();
                            return;
                        }
                    }
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (_draggedPointIndex >= 0)
            {
                var newPoint = FromScreen(e.Location);

                // Prevent moving first/last point horizontally (keep at 0 and 255)
                var sorted = _controlPoints.OrderBy(p => p.X).ToList();
                if (_controlPoints[_draggedPointIndex].X == sorted[0].X)
                    newPoint.X = 0;
                else if (_controlPoints[_draggedPointIndex].X == sorted[^1].X)
                    newPoint.X = 255;

                _controlPoints[_draggedPointIndex] = newPoint;
                Invalidate();
                OnCurveChanged();
            }

            // Change cursor when hovering over point
            bool overPoint = false;
            foreach (var point in _controlPoints)
            {
                var screenPos = ToScreen(point);
                float dist = (float)Math.Sqrt(Math.Pow(e.X - screenPos.X, 2) + Math.Pow(e.Y - screenPos.Y, 2));
                if (dist <= PointRadius + 2)
                {
                    overPoint = true;
                    break;
                }
            }
            Cursor = overPoint ? Cursors.Hand : Cursors.Default;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _draggedPointIndex = -1;
        }

        public void Reset()
        {
            _controlPoints.Clear();
            _controlPoints.Add(new PointF(0, 255));
            _controlPoints.Add(new PointF(255, 0));
            Invalidate();
            OnCurveChanged();
        }

        // Event for when curve changes
        public event EventHandler? CurveChanged;

        protected virtual void OnCurveChanged()
        {
            CurveChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
