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

        public Color Apply(Color inputColor)
        {
            return Color.FromArgb(
                _lookupTable[inputColor.R],
                _lookupTable[inputColor.G],
                _lookupTable[inputColor.B]
            );
        }
    }
}
