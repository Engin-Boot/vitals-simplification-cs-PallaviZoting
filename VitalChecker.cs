using System;
using System.Diagnostics;

namespace Vitals
{ 
 class VitalChecker
   {
      public static bool vitalsAreOk(float bpm, float spo2, float respRate)
      {
         bool vital1 = RangeChecker.rangeCheckerVitals(30,95,respRate);
         bool vital2 = RangeChecker.rangeCheckerVitals(90,100,spo2);
         bool vital3 = RangeChecker.rangeCheckerVitals(70,150,bpm);
         bool vitalcheck = vital1 && vital2 && vital3;
         return vitalcheck;
      }
   }
}
