using GK1P3.Misc;

namespace GK1P3.Filters
{
    internal class Brightness : IImageFilter
    {
        private readonly int _adjustment;

        public Brightness(double adjustment) // -1.00 to 1.00
        {
            _adjustment = (int)(adjustment * 255.0);
        }

        public Color Apply(Color inputColor)
        {
            byte r = Helpers.Clamp(inputColor.R + _adjustment);
            byte g = Helpers.Clamp(inputColor.G + _adjustment);
            byte b = Helpers.Clamp(inputColor.B + _adjustment);
            return Color.FromArgb(r, g, b);
        }
    }
}
