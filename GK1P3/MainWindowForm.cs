using GK1P3.Filters;
using GK1P3.Misc;

namespace GK1P3
{
    public partial class MainWindowForm : Form
    {
        private IImageFilter _filter { get; set; } = new Identity();
        private int _brushSize = 1;
        Bitmap? _loadedBitmap = null;

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
            _loadedBitmap = Helpers.LoadImageFromPath(fullPath) as Bitmap;
            CanvasPictureBox_PictureBox.Image = _loadedBitmap;
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
            _loadedBitmap = Helpers.LoadImage() as Bitmap;
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
            _loadedBitmap = _filter.Apply(_loadedBitmap);
            CanvasPictureBox_PictureBox.Image = _loadedBitmap;
            PlotHistograms();
        }

        private void BrushSize_TrackBar_Scroll(object sender, EventArgs e)
        {
            _brushSize = BrushSize_TrackBar.Value;
            BrushSizeValue_Label.Text = $"{_brushSize}";
        }

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
            if(Grayscale_RadioButton.Checked && _filter is not Grayscale)
            {
                _filter = new Grayscale();
            }
        }
    }
}
