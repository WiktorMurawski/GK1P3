namespace GK1P3.Misc
{
    internal static class ImageLoading
    {
        public static Bitmap? LoadImageFromPath(string path)
        {
            if (!File.Exists(path))
                return null;

            using var temp = new Bitmap(path);
            return new Bitmap(temp);
        }

        public static Bitmap? LoadImage()
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    return LoadImageFromPath(ofd.FileName);
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
    }
}
