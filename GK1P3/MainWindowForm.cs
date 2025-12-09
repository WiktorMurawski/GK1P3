using GK1P3.Misc;

namespace GK1P3
{
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();
            IntializeDefaults();
        }

        private void IntializeDefaults()
        {
            var resourcesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
            var fileName = "lena.png";
            var fullPath = Path.Combine(resourcesPath, fileName);
            CanvasPictureBox_PictureBox.Image = Helpers.LoadImageFromPath(fullPath);
            PlotHistograms();
        }

        private void PlotHistograms()
        {
            (var hR, var hG, var hB) = Helpers.GetHistograms(CanvasPictureBox_PictureBox.Image);
            Helpers.PlotHistogram(ChartRed_Chart, hR, Color.Red, "Red");
            Helpers.PlotHistogram(ChartGreen_Chart, hG, Color.Green, "Green");
            Helpers.PlotHistogram(ChartBlue_Chart, hB, Color.Blue, "Blue");
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CanvasPictureBox_PictureBox.Image = Helpers.LoadImage();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
