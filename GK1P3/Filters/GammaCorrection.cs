using System;
using System.Collections.Generic;
using System.Text;

namespace GK1P3.Filters
{
    internal class GammaCorrection(double gamma) : IImageFilter
    {
        Color IImageFilter.Apply(Color inputColor)
        {
            byte r = (byte)(Math.Pow(inputColor.R / 255.0, 1.0 / gamma) * 255);
            byte g = (byte)(Math.Pow(inputColor.G / 255.0, 1.0 / gamma) * 255);
            byte b = (byte)(Math.Pow(inputColor.B / 255.0, 1.0 / gamma) * 255);
            return Color.FromArgb(r, g, b);
        }
    }
}
