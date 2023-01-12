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
            listOfItems.Add(new EmailParam() { Breach = BreachType.TOO_HIGH, Recipient = Constants.MailRecipient, EmailMessage = Constants.EmailMessage_High });
            listOfItems.Add(new EmailParam() { Breach = BreachType.NORMAL, Recipient = Constants.MailRecipient, EmailMessage = Constants.EmailMessage_Normal });

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
