using System.Runtime.CompilerServices;

namespace GK1P3.Filters
{
    internal class Identity : IImageFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ApplyBytes(ref byte r, ref byte g, ref byte b) { }
    }
}
