using GK1P3.Filters;
using GK1P3.Misc;

namespace GK1P3
{
    public partial class MainWindowForm : Form
    {
        private IImageFilter _filter { get; set; } = new Identity();
        private int _brushSize { get; set; } = 1;
        private Bitmap? _loadedBitmap { get; set; } = null;

        public MainWindowForm()
        {
            InitializeComponent();
            IntializeDefaults();

            FunctionCurve_CurveEditorControl.CurveChanged += (s, e) =>
            {
                if (CustomFunction_RadioButton.Checked)
                {
                    var lookupTable = FunctionCurve_CurveEditorControl.GenerateLookupTable();
                    _filter = new CustomCurve(lookupTable);
                }
            };
        }

        private void IntializeDefaults()
        {
            _brushSize = BrushSize_TrackBar.Value;

            var resourcesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
            var fileName = "lena.png";
            var fullPath = Path.Combine(resourcesPath, fileName);
            _loadedBitmap = ImageLoading.LoadImageFromPath(fullPath) as Bitmap;
            CanvasPictureBox_PictureBox.Image = _loadedBitmap;
            PlotHistograms();
        }

        private void PlotHistograms()
        {
            (var hR, var hG, var hB) = Histograms.GetHistograms(CanvasPictureBox_PictureBox.Image);
            Histograms.PlotHistogram(ChartRed_Chart, hR, Color.Red, "Red");
            Histograms.PlotHistogram(ChartGreen_Chart, hG, Color.Green, "Green");
            Histograms.PlotHistogram(ChartBlue_Chart, hB, Color.Blue, "Blue");
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _loadedBitmap = ImageLoading.LoadImage();
            CanvasPictureBox_PictureBox.Image = _loadedBitmap;
            PlotHistograms();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplyFilter_Button_Click(object sender, EventArgs e)
        {
            if (_loadedBitmap is null) return;
            Cursor.Current = Cursors.WaitCursor;
            _loadedBitmap = _filter.Apply(_loadedBitmap);
            CanvasPictureBox_PictureBox.Image = _loadedBitmap;
            PlotHistograms();
            Cursor.Current = Cursors.Default;
        }

        private void BrushSize_TrackBar_Scroll(object sender, EventArgs e)
        {
            _brushSize = BrushSize_TrackBar.Value;
            BrushSizeValue_Label.Text = $"{_brushSize}";
        }

        #region Filters Radio Buttons
        private void None_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (None_RadioButton.Checked && _filter is not Identity)
            {
                _filter = new Identity();
            }
        }

        private void Invert_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Invert_RadioButton.Checked && _filter is not Invert)
            {
                _filter = new Invert();
            }
        }

        private void Grayscale_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Grayscale_RadioButton.Checked && _filter is not Grayscale)
            {
                _filter = new Grayscale();
            }
        }

        private void Sepia_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Sepia_RadioButton.Checked && _filter is not Sepia)
            {
                _filter = new Sepia();
            }
        }

        private void Gamma_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Gamma_RadioButton.Checked && _filter is not Gamma)
            {
                _filter = new Gamma((double)Gamma_NumericUpDown.Value);
            }
        }

        private void Gamma_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Gamma_RadioButton.Checked)
            {
                _filter = new Gamma((double)Gamma_NumericUpDown.Value);
            }
        }

        private void Contrast_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Contrast_RadioButton.Checked && _filter is not Contrast)
            {
                _filter = new Contrast((double)Contrast_NumericUpDown.Value);
            }
        }

        private void Contrast_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Contrast_RadioButton.Checked)
            {
                _filter = new Contrast((double)Contrast_NumericUpDown.Value);
            }
        }

        private void Brightness_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Brightness_RadioButton.Checked && _filter is not Brightness)
            {
                _filter = new Brightness((double)Brightness_NumericUpDown.Value);
            }
        }

        private void Brightness_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Brightness_RadioButton.Checked)
            {
                _filter = new Brightness((double)Brightness_NumericUpDown.Value);
            }
        }

        private void Posterize_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Posterize_RadioButton.Checked && _filter is not Posterize)
            {
                _filter = new Posterize((int)Posterize_NumericUpDown.Value);
            }

        }

        private void Posterize_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Posterize_RadioButton.Checked)
            {
                _filter = new Posterize((int)Posterize_NumericUpDown.Value);
            }
        }

        private void CustomFunction_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomFunction_RadioButton.Checked)
            {
                var lookupTable = FunctionCurve_CurveEditorControl.GenerateLookupTable();
                _filter = new CustomCurve(lookupTable);
            }
        }
        #endregion

        #region Brush drawing
        private bool _drawing = false;
        private HashSet<(int, int)> _touchedPixels = new();
        private Point _lastBrushPosition = Point.Empty;

        private void CanvasPictureBox_PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Point mouse = CanvasPictureBox_PictureBox.PointToClient(Cursor.Position);

            if (mouse.X >= 0 && mouse.X < CanvasPictureBox_PictureBox.Width && mouse.Y >= 0 && mouse.Y < CanvasPictureBox_PictureBox.Height)
            {
                using Pen pen = new(Color.Black);
                e.Graphics.DrawEllipse(pen, mouse.X - _brushSize, mouse.Y - _brushSize, _brushSize * 2, _brushSize * 2);
            }
        }

        private void CanvasPictureBox_PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_drawing && _loadedBitmap is not null)
            {
                _loadedBitmap = _filter.ApplyCircle(_loadedBitmap, e.X, e.Y, _brushSize, _touchedPixels);

                Rectangle invalidRect = new Rectangle(e.X - _brushSize - 5, e.Y - _brushSize - 5, _brushSize * 2 + 11, _brushSize * 2 + 11);
                CanvasPictureBox_PictureBox.Invalidate(invalidRect);
            }
            else
            {
                Rectangle cursorRect = new Rectangle(e.X - _brushSize - 1, e.Y - _brushSize - 1, _brushSize * 2 + 2, _brushSize * 2 + 2);

                if (_lastBrushPosition != Point.Empty)
                {
                    Rectangle oldCursorRect = new Rectangle(_lastBrushPosition.X - _brushSize - 1, _lastBrushPosition.Y - _brushSize - 1, _brushSize * 2 + 2, _brushSize * 2 + 2);
                    CanvasPictureBox_PictureBox.Invalidate(oldCursorRect);
                }

                CanvasPictureBox_PictureBox.Invalidate(cursorRect);
                _lastBrushPosition = e.Location;
            }
        }

        private void CanvasPictureBox_PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _drawing = true;
            _touchedPixels.Clear();

            Rectangle rectangle = new Rectangle(e.X - _brushSize - 1, e.Y - _brushSize - 1, _brushSize * 2 + 2, _brushSize * 2 + 2);

            if (_loadedBitmap is not null)
            {
                _loadedBitmap = _filter.ApplyCircle(_loadedBitmap, e.X, e.Y, _brushSize, _touchedPixels);
                CanvasPictureBox_PictureBox.Invalidate(rectangle);
            }
        }

        private void CanvasPictureBox_PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _drawing = false;
            _touchedPixels.Clear();

            Rectangle rectangle = new Rectangle(e.X - _brushSize - 1, e.Y - _brushSize - 1, _brushSize * 2 + 2, _brushSize * 2 + 2);
            if (_loadedBitmap is not null)
            {
                CanvasPictureBox_PictureBox.Invalidate(rectangle);
            }

            PlotHistograms();
        }
        #endregion
    }
}
