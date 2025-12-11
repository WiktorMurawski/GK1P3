namespace GK1P3.Filters
{
    internal class Grayscale : IImageFilter
    {
        private const double _redWeight = 0.299;
        private const double _greenWeight = 0.587;
        private const double _blueWeight = 0.114;

        public void ApplyBytes(ref byte r, ref byte g, ref byte b)
        {
            byte gray = (byte)(_redWeight * r + _greenWeight * g + _blueWeight * b);
            r = gray;
            g = gray;
            b = gray;
        }
    }
}
