using System.Runtime.CompilerServices;

namespace GK1P3.Filters
{
    internal class Posterize : IImageFilter
    {
        private readonly int _levels;

        public Posterize(int levels) // 2 to 256
        {
            _levels = Math.Max(2, Math.Min(256, levels));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ApplyBytes(ref byte r, ref byte g, ref byte b)
        {
            int step = 256 / _levels;
            r = (byte)((r / step) * step);
            g = (byte)((g / step) * step);
            b = (byte)((b / step) * step);
        }
    }
}
