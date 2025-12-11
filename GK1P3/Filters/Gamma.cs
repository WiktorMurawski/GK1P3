using GK1P3.Misc;

namespace GK1P3.Filters
{
    internal class Gamma : IImageFilter
    {
        private double _gamma;
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

        public void ApplyBytes(ref byte r, ref byte g, ref byte b)
        {
            r = _lookupTable[r];
            g = _lookupTable[g];
            b = _lookupTable[b];
        }
    }
}
