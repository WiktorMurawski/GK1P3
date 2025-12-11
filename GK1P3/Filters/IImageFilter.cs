using System.Drawing.Imaging;

namespace GK1P3.Filters
{
    internal interface IImageFilter
    {
        void ApplyBytes(ref byte r, ref byte g, ref byte b);

        unsafe Bitmap Apply(Bitmap inputBitmap)
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

                        ApplyBytes(ref r, ref g, ref b);

                        row[offset] = b;
                        row[offset + 1] = g;
                        row[offset + 2] = r;
                    }
                }
            }
            finally
            {
                inputBitmap.UnlockBits(bitmapData);
            }

            return inputBitmap;
        }

        unsafe Bitmap ApplyCircle(Bitmap inputBitmap, int x0, int y0, int radius, HashSet<(int, int)> touchedPixels)
        {
            int width = inputBitmap.Width;
            int height = inputBitmap.Height;

            if (x0 + radius < 0 || x0 - radius >= width || y0 + radius < 0 || y0 - radius >= height)
                return inputBitmap;

            int radius2 = radius * radius;

            Rectangle rect = new Rectangle(0, 0, width, height);
            BitmapData bitmapData = inputBitmap.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int maxy = Math.Min(height, y0 + radius);
            int maxx = Math.Min(width, x0 + radius);
            int miny = Math.Max(0, y0 - radius);
            int minx = Math.Max(0, x0 - radius);

            try
            {
                int bytesPerPixel = 3;
                int stride = bitmapData.Stride;
                byte* scan0 = (byte*)bitmapData.Scan0;

                for (int y = miny; y < maxy; y++)
                {
                    byte* row = scan0 + (y * stride);
                    int dy = y - y0;
                    int dy2 = dy * dy;

                    for (int x = minx; x < maxx; x++)
                    {
                        if (touchedPixels.Contains((x, y)))
                            continue;

                        int dx = (int)(x - x0);
                        if (dx * dx + dy2 > radius2)
                            continue;

                        touchedPixels.Add((x, y));

                        int offset = x * bytesPerPixel;

                        byte b = row[offset];
                        byte g = row[offset + 1];
                        byte r = row[offset + 2];

                        ApplyBytes(ref r, ref g, ref b);

                        row[offset] = b;
                        row[offset + 1] = g;
                        row[offset + 2] = r;
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
