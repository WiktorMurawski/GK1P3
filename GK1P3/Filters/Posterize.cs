namespace GK1P3.Filters
{
    internal class Posterize : IImageFilter
    {
        private readonly int _levels;

        public Posterize(int levels) // 2 to 256
        {
            _levels = Math.Max(2, Math.Min(256, levels));
        }

        public Color Apply(Color inputColor)
        {
            int step = 256 / _levels;

            byte r = (byte)((inputColor.R / step) * step);
            byte g = (byte)((inputColor.G / step) * step);
            byte b = (byte)((inputColor.B / step) * step);

            return Color.FromArgb(r, g, b);
        }
    }
}
