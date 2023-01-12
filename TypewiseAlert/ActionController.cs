using System;
using static TypewiseAlert.TypeWiseEnums;

namespace TypewiseAlert
{
    public class ActionController{
        public static bool sendToController(BreachType breachType) 
        {
            try
            {
                const ushort header = 0xfeed;
                Console.WriteLine("{} : {}\n", header, breachType);

                return true;
            }
            catch(Exception)
            {
                return false;
            }            
        }
    }
}     
