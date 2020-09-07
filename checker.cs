using System;
using System.Diagnostics;

namespace Vitals
{
    class Checker
    {
        static int Main(string[] args)
      {
        ResultExpect.ExpectTrue(VitalChecker.vitalsAreOk(100, 95, 60));//1 1 1
        ResultExpect.ExpectFalse(VitalChecker.vitalsAreOk(40, 91, 92));//0 1 1
        ResultExpect.ExpectFalse(VitalChecker.vitalsAreOk(60, 85, 98));//0 0 0
        ResultExpect.ExpectFalse(VitalChecker.vitalsAreOk(60, 85, 92));//0 0 1
        ResultExpect.ExpectFalse(VitalChecker.vitalsAreOk(60, 91, 98));//0 1 0
        ResultExpect.ExpectFalse(VitalChecker.vitalsAreOk(100, 85, 98));//1 0 0
        ResultExpect.ExpectFalse(VitalChecker.vitalsAreOk(100, 85, 92));//1 0 1
        ResultExpect.ExpectFalse(VitalChecker.vitalsAreOk(100, 95, 98));//1 1 0
        ResultExpect.ExpectTrue(VitalChecker.vitalsAreOk(120, 95, 92));//1 1 1
        Console.WriteLine("All ok");
        return 0;
       }
    }
}
