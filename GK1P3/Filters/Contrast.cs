using GK1P3.Misc;
using System;
using System.Collections.Generic;
using System.Text;

namespace GK1P3.Filters
{
    internal class Contrast : IImageFilter
    {
        private readonly double _factor;

        public Contrast(double factor) // 0.01 to 2.00
        {
            _factor = factor;
        }

        public Color Apply(Color inputColor)
        {
            byte r = Helpers.Clamp((int)((inputColor.R - 128) * _factor + 128));
            byte g = Helpers.Clamp((int)((inputColor.G - 128) * _factor + 128));
            byte b = Helpers.Clamp((int)((inputColor.B - 128) * _factor + 128));
            return Color.FromArgb(r, g, b);
        }
    }
}
