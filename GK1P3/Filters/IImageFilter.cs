using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Text;

namespace GK1P3.Filters
{
    internal interface IImageFilter
    {
        public Color Apply(Color inputColor);
        public unsafe Bitmap Apply(Bitmap inputBitmap)
        {
            int width = inputBitmap.Width;
            int height = inputBitmap.Height;

            Rectangle rect = new Rectangle(0, 0, width, height);
            BitmapData bitmapData = inputBitmap.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            try
            {
                int bytesPerPixel = 3;
                int stride = bitmapData.Stride;
                byte* scan0 = (byte*)bitmapData.Scan0;

                for (int y = 0; y < height; y++)
                {
                    byte* row = scan0 + (y * stride);

                    for (int x = 0; x < width; x++)
                    {
                        int offset = x * bytesPerPixel;

                        byte b = row[offset];
                        byte g = row[offset + 1];
                        byte r = row[offset + 2];

                        Color originalColor = Color.FromArgb(r, g, b);
                        Color newColor = Apply(originalColor);

                        row[offset] = newColor.B;
                        row[offset + 1] = newColor.G;
                        row[offset + 2] = newColor.R;
                    }
                }
            }
            finally
            {
                inputBitmap.UnlockBits(bitmapData);
            }

            return inputBitmap;
        }
        //public Bitmap Apply(Bitmap inputBitmap)
        //{
        //    int width = inputBitmap.Width;
        //    int height = inputBitmap.Height;
        //    for (int y = 0; y < height; y++)
        //    {
        //        for (int x = 0; x < width; x++)
        //        {
        //            Color originalColor = inputBitmap.GetPixel(x, y);
        //            Color newColor = Apply(originalColor);
        //            inputBitmap.SetPixel(x, y, newColor);
        //        }
        //    }
        //    return inputBitmap;
        //}
    }
}
