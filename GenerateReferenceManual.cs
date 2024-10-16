
using System;
using System.Drawing;
using System.Diagnostics;

namespace TelCo.ColorCoder
{
  partial class GenerateRefrenceManual
  {
    public Color[] MajorColor;
    public Color[] MinorColor;
    
    /// <summary>
    /// Print the mapping between color-names to the corresponding numbers.
    /// </summary>
    private static string ReferenceManualGenerator()
    {
      GenerateRefrenceManual.MinorColor;
      GenerateRefrenceManual.MajorColor;
      int colorCode = 1;
      string manual = "_________________________________________\n";
      manual += String.Format("|{0}\t|{1}\t|{2}|\n", "Major Color", "Minor Color", "Pair No");

      foreach(var majorColor in MajorColor)
      {
        foreach(var minorColor in MinorColor)
        {
          manual += String.Format("|{0}\t\t|{1}\t\t|{2}|\n", MajorColor.Name, MinorColor.Name, colorCode);
          colorCode++;
        }
      }
     return manual; 
    }
  }
}
