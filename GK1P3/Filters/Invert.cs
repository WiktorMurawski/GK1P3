using System.Runtime.CompilerServices;

namespace GK1P3.Filters
{
    internal class Invert : IImageFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ApplyBytes(ref byte r, ref byte g, ref byte b)
        {
            r = (byte)(255 - r);
            g = (byte)(255 - g);
            b = (byte)(255 - b);
        }
    }
}
