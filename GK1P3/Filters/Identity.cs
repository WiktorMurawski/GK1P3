using System;
using System.Collections.Generic;
using System.Text;

namespace GK1P3.Filters
{
    internal class Identity : IImageFilter
    {
        public Color Apply(Color inputColor)
        {
            return inputColor;
        }
    }
}
