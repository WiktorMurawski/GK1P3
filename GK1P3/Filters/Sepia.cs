using GK1P3.Misc;
using System.Runtime.CompilerServices;

namespace GK1P3.Filters
{
    internal class Sepia : IImageFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ApplyBytes(ref byte r, ref byte g, ref byte b)
        {
            int tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
            int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
            int tb = (int)(0.272 * r + 0.534 * g + 0.131 * b);
            r = Helpers.Clamp(tr);
            g = Helpers.Clamp(tg);
            b = Helpers.Clamp(tb);
        }
    }
}
