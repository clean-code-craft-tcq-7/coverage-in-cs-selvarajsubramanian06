using System;
using static TypewiseAlert.TypeWiseEnums

namespace TypewiseAlert
{
    public class ActionController{
        public static void sendToController(BreachType breachType) {
          const ushort header = 0xfeed;
          Console.WriteLine("{} : {}\n", header, breachType);
        }
    }
}     
