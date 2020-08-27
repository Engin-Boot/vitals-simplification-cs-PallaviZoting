using System;
using System.Diagnostics;
namespace CheckVital
{
class VitalChecker
{
    public static bool vitalsAreOk(float bpm, float spo2, float respRate) {
        if(bpm < 70 || bpm > 150) {
            return false;
        } else if(spo2 < 90) {
            return false;
        } else if(respRate < 30 || respRate > 95) {
            return false;
        }
        return true;
    }    
}
}
