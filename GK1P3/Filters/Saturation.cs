using GK1P3.Misc;

namespace GK1P3.Filters
{
    internal class Saturation : IImageFilter
    {
        private readonly double _factor;

        public Saturation(double factor) // 0.01 to 2.00
        {
            _factor = factor;
        }

        public Color Apply(Color inputColor)
        {
            double gray = 0.299 * inputColor.R + 0.587 * inputColor.G + 0.114 * inputColor.B;

            byte r = Helpers.Clamp((int)(gray + (inputColor.R - gray) * _factor));
            byte g = Helpers.Clamp((int)(gray + (inputColor.G - gray) * _factor));
            byte b = Helpers.Clamp((int)(gray + (inputColor.B - gray) * _factor));

            return Color.FromArgb(r, g, b);
        }
    }
}
