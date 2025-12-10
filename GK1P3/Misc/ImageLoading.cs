using System;
using System.Collections.Generic;
using System.Text;

namespace GK1P3.Misc
{
    internal static class ImageLoading
    {
        public static Image LoadImageFromPath(string path)
        {
            return new Bitmap(path);
        }

        public static Bitmap? LoadImage()
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
    }
}
