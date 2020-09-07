using System;
using System.Diagnostics;

namespace Vitals
{ 
    class AbnormalReading
    {
      public static void abnormal_respRate(float lowerlimit,float upperlimit, float vitalreading)
       {
        if(vitalreading > upperlimit) 
         {
          Console.WriteLine("Respiratory Rate {0} is too High", vitalreading);
         } 
         else if(vitalreading < lowerlimit)
         {
          Console.WriteLine("Respiratory Rate {0} is too Low", vitalreading);
	       }
       }
	
      public static void abnormal_spo2(float lowerlimit,float upperlimit, float vitalreading)
      {
        if(vitalreading > upperlimit) 
         {
          Console.WriteLine("Spo2 {0} is too High", vitalreading);
         } 
        else if(vitalreading < lowerlimit)
         {
           Console.WriteLine("Spo2 {0} is too Low", vitalreading);
	       }
       }
		
      public static void abnormal_bpm(float lowerlimit,float upperlimit, float vitalreading)
      {
         if(vitalreading > upperlimit) 
          {
           Console.WriteLine("Blood pressure {0} is too High", vitalreading);
          } 
         else if(vitalreading < lowerlimit)
          {
           Console.WriteLine("Blood pressure {0} is too Low", vitalreading);
	        }
       }
    }
}
