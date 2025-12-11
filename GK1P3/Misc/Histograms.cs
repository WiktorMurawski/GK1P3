using System.Windows.Forms.DataVisualization.Charting;

namespace GK1P3.Misc
{
    internal static class Histograms
    {
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
