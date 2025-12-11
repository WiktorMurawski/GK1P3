namespace GK1P3.Filters
{
    internal class Invert : IImageFilter
    {
        public void ApplyBytes(ref byte r, ref byte g, ref byte b)
        {
            r = (byte)(255 - r);
            g = (byte)(255 - g);
            b = (byte)(255 - b);
        }
    }
}
