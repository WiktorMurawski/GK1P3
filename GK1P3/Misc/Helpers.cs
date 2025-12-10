using System.Numerics;

namespace GK1P3.Misc
{
    internal static class Helpers
    {
        public static byte Clamp<T>(T value) where T : INumber<T>
        {
            return byte.CreateSaturating(value);
        }
    }
}
