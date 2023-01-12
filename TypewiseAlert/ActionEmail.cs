using System;
using static TypewiseAlert.TypeWiseEnums;

namespace TypewiseAlert
{
    public class ActionEmail;
    {
        /*static MyStruct[] myArray = 
            new MyStruct[]{
                new MyStruct() { id = 1, label = "1" },
                new MyStruct() { id = 2, label = "2" },
                new MyStruct() { id = 3, label = "3" },
            new MyStruct() { id = 3, label = "3" }
            };
        */
           public static void sendToEmail(BreachType breachType) {
         
         //breachType sol = breachType.NORMAL;
            List<EmailParam> listOfItems = new List<EmailParam>();
            listOfItems.Add(new EmailParam() { Breach = BreachType.TOO_LOW, Recipient = "ab@c.com", EmailMessage = "Hi, the temperature is too low" });
            listOfItems.Add(new EmailParam() { Breach = BreachType.TOO_HIGH, Recipient = "ab@d.com", EmailMessage = "Hi, the temperature is too high" });
            listOfItems.Add(new EmailParam() { Breach = BreachType.NORMAL, Recipient = "ab@e.com", EmailMessage = "Hi, the temperature is normal" });

            EmailParam value = listOfItems.Find(m => m.Breach == breachType);

            Console.WriteLine(value.Recipient);
            Console.WriteLine(value.EmailMessage);
            /*
         
      string recepient = "a.b@c.com";
      switch(breachType) {
        case BreachType.TOO_LOW:
          Console.WriteLine("To: {}\n", recepient);
          Console.WriteLine("Hi, the temperature is too low\n");
          break;
        case BreachType.TOO_HIGH:
          Console.WriteLine("To: {}\n", recepient);
          Console.WriteLine("Hi, the temperature is too high\n");
          break;*/
      }
    
  }
}    
