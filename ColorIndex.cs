using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelCo.ColorCoder;

namespace ColorCoding
{
    internal class GetColorIndex : ColorMapping
    {
        public int Major(PairColor Pair)
        {
        return Array.IndexOf(MajorColorMapping, Pair.MajorColor);
        }

        public int Minor(PairColor Pair)
        {
        return Array.IndexOf(MinorColorMapping, Pair.MinorColor);
        }            
    }
}
