using System;
using static TypewiseAlert.TypeWiseEnums;

namespace TypewiseAlert
{
    public class ActionEmai;
    {
     public static void sendToEmail(BreachType breachType) {
      string recepient = "a.b@c.com";
      switch(breachType) {
        case BreachType.TOO_LOW:
          Console.WriteLine("To: {}\n", recepient);
          Console.WriteLine("Hi, the temperature is too low\n");
          break;
        case BreachType.TOO_HIGH:
          Console.WriteLine("To: {}\n", recepient);
          Console.WriteLine("Hi, the temperature is too high\n");
          break;
        case BreachType.NORMAL:
          break;
      }
    }
}    
