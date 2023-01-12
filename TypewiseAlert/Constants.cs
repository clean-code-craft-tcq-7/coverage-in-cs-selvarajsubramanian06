using System;

namespace TypewiseAlert
{
    public static class Constants
    {
      public const string MailRecipient = "ab@c.com";
      public const string EmailMessage_Low = "Hi, the temperature is too low"; 
      public const string EmailMessage_High = "Hi, the temperature is too high"; 
      public const string EmailMessage_Normal = "Hi, the temperature is normal"; 
        
      public const double PassiveLowLimit = 0;
      public const double PassiveHighLimit = 35;
      public const double HiActiveLowLimit = 0;
      public const double HiActiveHighLimit = 45;
      public const double MedActiveLowLimit = 0;
      public const double MedActiveHighLimit = 40;        
    }
}
