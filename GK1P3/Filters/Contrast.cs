using GK1P3.Misc;
using System.Runtime.CompilerServices;

namespace GK1P3.Filters
{
    internal class Contrast : IImageFilter
    {
        private readonly double _factor;

        public Contrast(double factor) // 0.01 to 2.00
        {
            _factor = factor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ApplyBytes(ref byte r, ref byte g, ref byte b)
        {
            r = Helpers.Clamp((int)((r - 128) * _factor + 128));
            g = Helpers.Clamp((int)((g - 128) * _factor + 128));
            b = Helpers.Clamp((int)((b - 128) * _factor + 128));
        }
    }
}
