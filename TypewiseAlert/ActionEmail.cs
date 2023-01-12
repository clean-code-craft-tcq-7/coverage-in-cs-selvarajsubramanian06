using System;
using System.Collections.Generic;
using static TypewiseAlert.TypeWiseEnums;

namespace TypewiseAlert
{
    public class ActionEmail
    {
        public static bool sendToEmail(BreachType breachType) 
        {
        try 
            {
            List<EmailParam> listOfItems = new List<EmailParam>();
            listOfItems.Add(new EmailParam() { Breach = BreachType.TOO_LOW, Recipient = Constants.MailRecipient, EmailMessage = Constants.EmailMessage_Low });
            listOfItems.Add(new EmailParam() { Breach = BreachType.TOO_HIGH, Recipient = "ab@d.com", EmailMessage = "Hi, the temperature is too high" });
            listOfItems.Add(new EmailParam() { Breach = BreachType.NORMAL, Recipient = "ab@e.com", EmailMessage = "Hi, the temperature is normal" });

            EmailParam value = listOfItems.Find(m => m.Breach == breachType);

            Console.WriteLine(value.Recipient);
            Console.WriteLine(value.EmailMessage);
            
            return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}    
