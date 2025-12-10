using GK1P3.Misc;

namespace GK1P3.Filters
{
    internal class Sepia : IImageFilter
    {
        public Color Apply(Color inputColor)
        {
            int tr = (int)(0.393 * inputColor.R + 0.769 * inputColor.G + 0.189 * inputColor.B);
            int tg = (int)(0.349 * inputColor.R + 0.686 * inputColor.G + 0.168 * inputColor.B);
            int tb = (int)(0.272 * inputColor.R + 0.534 * inputColor.G + 0.131 * inputColor.B);

            return Color.FromArgb(
                Helpers.Clamp(tr),
                Helpers.Clamp(tg),
                Helpers.Clamp(tb)
            );
        }
    }
}
