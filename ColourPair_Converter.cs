
namespace TelCo.ColorCoder
{
    partial class Program
    {
        /// <summary>
        /// Given a pair number, returns the major and minor colors in that order.
        /// </summary>
        /// <param name="pairNumber">Pair number of the color to be fetched.</param>
        private static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            ValidatePairNumber(pairNumber);
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / colorMapMinor.Length;
            int minorIndex = zeroBasedPairNumber % colorMapMinor.Length;

            return new ColorPair
            {
                majorColor = colorMapMajor[majorIndex],
                minorColor = colorMapMinor[minorIndex]
            };
        }

        /// <summary>
        /// Given the two colors, returns the pair number corresponding to them.
        /// </summary>
        /// <param name="pair">Color pair with major and minor color.</param>
        private static int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex = GetIndex(colorMapMajor, pair.majorColor);
            int minorIndex = GetIndex(colorMapMinor, pair.minorColor);
            
            return (majorIndex * colorMapMinor.Length) + (minorIndex + 1);
        }

        private static void ValidatePairNumber(int pairNumber)
        {
            if (pairNumber < 1 || pairNumber > colorMapMinor.Length * colorMapMajor.Length)
            {
                throw new ArgumentOutOfRangeException($"Argument PairNumber:{pairNumber} is outside the allowed range.");
            }
        }

        private static int GetIndex(Color[] colorMap, Color color)
        {
            int index = Array.IndexOf(colorMap, color);
            if (index == -1)
            {
                throw new ArgumentException($"Unknown Color: {color}");
            }
            return index;
        }
    }
}
