using System.Windows.Forms.DataVisualization.Charting;

namespace GK1P3.Misc
{
    internal static class Helpers
    {
        public static Image LoadImageFromPath(string path)
        {
            return new Bitmap(path);
        }

        public static Image? LoadImage()
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using var temp = new Bitmap(ofd.FileName);
                    return new Bitmap(temp);
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public static (int[] R, int[] G, int[] B) GetHistograms(Image? image)
        {
            if (image is not Bitmap bitmap)
            {
                throw new ArgumentException("Image must be a Bitmap.", nameof(image));
            }
            return GetHistograms(bitmap);
        }

        public static (int[] R, int[] G, int[] B) GetHistograms(Bitmap bitmap)
        {
            var histogramR = new int[256];
            var histogramG = new int[256];
            var histogramB = new int[256];
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    histogramR[pixelColor.R]++;
                    histogramG[pixelColor.G]++;
                    histogramB[pixelColor.B]++;
                }
            }
            return (histogramR, histogramG, histogramB);
        }

        public static void PlotHistogram(Chart chart, int[] values, Color color, string title)
        {
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Legends.Clear();

            chart.ChartAreas[0].AxisY.Minimum = 0;
            chart.ChartAreas[0].AxisX.Minimum = 0;
            chart.ChartAreas[0].AxisX.Maximum = 255;

            var axisX = chart.ChartAreas[0].AxisX;
            axisX.LabelStyle.Enabled = true;
            int[] positions = { 0, 63, 127, 191, 255 };
            foreach (int pos in positions)
            {
                CustomLabel label = new CustomLabel
                {
                    FromPosition = pos - 100,
                    ToPosition = pos + 100,
                    Text = pos.ToString()
                };
                axisX.CustomLabels.Add(label);
            }

            Series s = new Series
            {
                ChartType = SeriesChartType.Column,
                Color = color,
                BorderWidth = 1
            };

            for (int i = 0; i < 256; i++)
            {
                s.Points.AddXY(i, values[i]);
            }

            chart.Series.Add(s);
        }

    }
}
