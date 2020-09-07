using System;
using System.Diagnostics;

namespace Vitals
{ 
      class RangeChecker
      {
          public static bool rangeCheckerVitals(float lowerlimit,float upperlimit, float vitalreading)
        {
          if(vitalreading > upperlimit || vitalreading < lowerlimit) 
           {
            return false;
           } 
            return true;
        }
     }
}
