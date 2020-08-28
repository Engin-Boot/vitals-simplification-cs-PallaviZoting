using System;
using System.Diagnostics;

namespace Vitals
{
  class BmpChecker
    {
    public static bool bmpVitalsAreOk(float bpm) {
        if(bpm < 70 || bpm > 150) {
            return false;
        } 
        return true;
      }
    }
}
