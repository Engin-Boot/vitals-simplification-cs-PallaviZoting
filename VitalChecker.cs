using System;
using System.Diagnostics;

namespace Vitals
{
class VitalChecker
{
   public static bool vitalsAreOk(float bpm, float spo2, float respRate) {
   if (RespRateChecker.respRateVitalsareOk(respRate) && Spo2Checker.spo2VitalsareOk(spo2) && BmpChecker.bmpVitalsareOk(bmp))
    {
        return true;
    }
    else{
    return false;
    }
}
}