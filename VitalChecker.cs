using System;
using System.Diagnostics;

namespace Vitals
{
   class VitalChecker
   {
      public static bool vitalsAreOk(float bpm, float spo2, float respRate)
      {
         bool vital1 = RespRateChecker.respRatevitalsAreOk(respRate);
         bool vital2 = Spo2Checker.spo2vitalsAreOk(spo2);
         bool vital3 = BmpChecker.bmpVitalsAreOk(bpm);
         bool vitalcheck = vital1 && vital2 && vital3;
         return vitalcheck;
      }
   }
}
