using System;
using System.Diagnostics;

namespace Vitals
{
   class VitalChecker
   {
      public static bool vitalsAreOk(float bpm, float spo2, float respRate) {
      if (RespRateChecker.respRatevitalsAreOk(respRate) && Spo2Checker.spo2vitalsAreOk(spo2) && BmpChecker.bmpVitalsAreOk(bpm))
      {
        return true;
      }
      else{
        return false;
      }
      }
  }
}
