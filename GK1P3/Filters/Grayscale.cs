using System;
using System.Collections.Generic;
using System.Text;

namespace GK1P3.Filters
{
    internal class Grayscale : IImageFilter
    {
        public Color Apply(Color inputColor)
        {
            byte gray = (byte)(0.299 * inputColor.R + 0.587 * inputColor.G + 0.114 * inputColor.B);
            return Color.FromArgb(gray, gray, gray);
        }
    }
}
