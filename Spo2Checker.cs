using System;
using System.Diagnostics;

namespace Vitals
{
      class Spo2Checker
      {
        public static bool spo2vitalsAreOk(float spo2) {
        if(spo2 < 90) {
            return false;
        } 
        return true;
      }
    }
}