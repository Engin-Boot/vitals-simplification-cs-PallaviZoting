using System;
using System.Diagnostics;
using static VitalChecker;

namespace CheckVital
{    
class Checker
{
    static int Main() {
        ExpectTrue(vitalsAreOk(100, 95, 60));
        ExpectFalse(vitalsAreOk(40, 91, 92));
        Console.WriteLine("All ok");
        return 0;
    }
}
}
