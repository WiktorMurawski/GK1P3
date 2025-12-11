using GK1P3.Misc;

namespace GK1P3.Filters
{
    internal class Brightness : IImageFilter
    {
        private readonly int _adjustment;

        public Brightness(double adjustment) // 0.00 to 2.00
        {
            _adjustment = (int)((adjustment - 1.0) * 255.0);
        }

        public void ApplyBytes(ref byte r, ref byte g, ref byte b)
        {
            r = Helpers.Clamp(r + _adjustment);
            g = Helpers.Clamp(g + _adjustment);
            b = Helpers.Clamp(b + _adjustment);
        }
    }
}
