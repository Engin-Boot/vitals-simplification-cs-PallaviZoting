using System;
using System.Diagnostics;

namespace Vitals
{
   class VitalChecker
   {
      public static bool vitalsAreOk(float bpm, float spo2, float respRate) {
      if (RespRateChecker.respRateVitalsAreOk(respRate) && Spo2Checker.spo2VitalsAreOk(spo2) && BmpChecker.bmpVitalsAreOk(bmp))
      {
        return true;
      }
      else{
        return false;
      }
      }
  }
}
