using GK1P3.Misc;
using System;
using System.Collections.Generic;
using System.Text;

namespace GK1P3.Filters
{
    internal class ContrastCorrection : IImageFilter
    {
        public Color Apply(Color inputColor)
        {
            float factor = (259 * (128 + 255)) / (255 * (259 - 128));
            byte r = Helpers.Clamp((int)(factor * (inputColor.R - 128) + 128));
            byte g = Helpers.Clamp((int)(factor * (inputColor.G - 128) + 128));
            byte b = Helpers.Clamp((int)(factor * (inputColor.B - 128) + 128));
            return Color.FromArgb(r, g, b);
        }
    }
}
