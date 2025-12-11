using System.Drawing.Imaging;
using System.Runtime.CompilerServices;

namespace GK1P3.Filters
{
    internal interface IImageFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
                    byte* pixel = scan0 + (y * stride);
                    byte* rowEnd = pixel + (width * 3);

                    while (pixel < rowEnd)
                    {
                        byte b = pixel[0];
                        byte g = pixel[1];
                        byte r = pixel[2];

                        ApplyBytes(ref r, ref g, ref b);

                        pixel[0] = b;
                        pixel[1] = g;
                        pixel[2] = r;

                        pixel += bytesPerPixel;
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

            int maxy = Math.Min(height, y0 + radius + 1);
            int maxx = Math.Min(width, x0 + radius + 1);
            int miny = Math.Max(0, y0 - radius);
            int minx = Math.Max(0, x0 - radius);

            try
            {
                int bytesPerPixel = 3;
                int stride = bitmapData.Stride;
                byte* scan0 = (byte*)bitmapData.Scan0;

                for (int y = miny; y < maxy; y++)
                {
                    int dy = y - y0;
                    int dySquared = dy * dy;
                    byte* row = scan0 + (y * stride);

                    for (int x = minx; x < maxx; x++)
                    {
                        int dx = x - x0;

                        if (dx * dx + dySquared > radius2)
                            continue;

                        if (!touchedPixels.Add((x, y)))
                            continue;

                        byte* pixel = row + (x * bytesPerPixel);

                        byte b = pixel[0];
                        byte g = pixel[1];
                        byte r = pixel[2];

                        ApplyBytes(ref r, ref g, ref b);

                        pixel[0] = b;
                        pixel[1] = g;
                        pixel[2] = r;
                    }
                }
            }
            finally
            {
                inputBitmap.UnlockBits(bitmapData);
            }

            return inputBitmap;
        }
    }
}
