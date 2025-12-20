using GK1P3.Misc;
using System.Runtime.CompilerServices;

namespace GK1P3.Filters
{
    internal class Gamma : IImageFilter
    {
        private readonly double _gamma;
        private readonly byte[] _lookupTable = new byte[256];

        public Gamma(double gamma) // 0.01 to 5.00
        {
            _gamma = gamma;
            CalculateLUT();
        }

        private void CalculateLUT()
        {
            for (int i = 0; i < 256; i++)
            {
                _lookupTable[i] = Helpers.Clamp((int)(Math.Pow(i / 255.0, 1.0 / _gamma) * 255.0));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ApplyBytes(ref byte r, ref byte g, ref byte b)
        {
            r = _lookupTable[r];
            g = _lookupTable[g];
            b = _lookupTable[b];
        }
    }
}
