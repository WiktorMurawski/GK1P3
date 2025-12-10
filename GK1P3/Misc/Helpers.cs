using System.Numerics;
using System.Windows.Forms.DataVisualization.Charting;

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
