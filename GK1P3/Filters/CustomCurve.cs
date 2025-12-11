namespace GK1P3.Filters
{
    internal class CustomCurve : IImageFilter
    {
        private readonly byte[] _lookupTable;

        public CustomCurve(byte[] lookupTable)
        {
            if (lookupTable.Length != 256)
                throw new ArgumentException("Lookup table must have exactly 256 entries.");

            _lookupTable = lookupTable;
        }

        public void ApplyBytes(ref byte r, ref byte g, ref byte b)
        {
            r = _lookupTable[r];
            g = _lookupTable[g];
            b = _lookupTable[b];
        }
    }
}
