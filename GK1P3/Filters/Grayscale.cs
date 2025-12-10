using System;
using System.Collections.Generic;
using System.Text;

namespace GK1P3.Filters
{
    internal class Grayscale : IImageFilter
    {
        public Color Apply(Color inputColor)
        {
            double redWeight = 0.299;
            double greenWeight = 0.587;
            double blueWeight = 0.114;
            byte gray = (byte)(redWeight * inputColor.R + greenWeight * inputColor.G + blueWeight * inputColor.B);
            return Color.FromArgb(gray, gray, gray);
        }
    }
}
