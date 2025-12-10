namespace GK1P3.Filters
{
    internal class Invert : IImageFilter
    {
        public Color Apply(Color inputColor)
        {
            byte r = (byte)(255 - inputColor.R);
            byte g = (byte)(255 - inputColor.G);
            byte b = (byte)(255 - inputColor.B);
            return Color.FromArgb(r, g, b);
        }
    }
}
