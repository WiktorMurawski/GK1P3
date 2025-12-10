namespace GK1P3.Filters
{
    internal class Identity : IImageFilter
    {
        public Color Apply(Color inputColor)
        {
            return inputColor;
        }
    }
}
