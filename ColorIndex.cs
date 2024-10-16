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
        public int GetMajorColorIndex(PairColor pair)
        {
        return Array.IndexOf(MajorColorMapping, pair.MajorColor);
        }

        public int GetMinorColorIndexOf(PairColor pair)
        {
        return Array.IndexOf(MinorColorMapping, pair.MinorColor);
        }            
    }
}
