
using System;
using System.Drawing;
using System.Diagnostics;

namespace TelCo.ColorCoder
{
  partial class GenerateRefrenceManual
  {
   private static Color[] MajorColor{get;set;}
    private static Color[] MinorColor{get;set;}
    
    /// <summary>
    /// Print the mapping between color-names to the corresponding numbers.
    /// </summary>
    private static string GenerateReferenceManual()
    {
      if(MajorColor == null || MinorColor == null)
      {
        throw new InvalidOperationException("MajorColor and MinorColor arrays must be initialized.");
      }
      
      int colorCode = 1;
      string manual = "_________________________________________\n";
      manual += String.Format("|{0}\t|{1}\t|{2}|\n", "Major Color", "Minor Color", "Pair No");

      foreach(var majorColor in MajorColor)
      {
        foreach(var minorColor in MinorColor)
        {
          manual += String.Format("|{0}\t\t|{1}\t\t|{2}|\n", majorcolor.Name, minorcolor.Name, colorCode);
          colorCode++;
        }
      }
      manual +="___________________________________________________";
     return manual; 
    }
  }
}
