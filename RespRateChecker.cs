using System;
using System.Diagnostics;

namespace Vitals
{
  class RespRateChecker
   {
    public static bool respRatevitalsAreOk(float respRate) {
        if(respRate < 30 || respRate > 95) {
            return false;
        }
        return true;
    }
  }
}