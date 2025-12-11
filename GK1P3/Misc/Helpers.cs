using System.Numerics;
using System.Runtime.CompilerServices;

namespace GK1P3.Misc
{
    internal static class Helpers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Clamp<T>(T value) where T : INumber<T>
        {
            return byte.CreateSaturating(value);
        }
    }
}
