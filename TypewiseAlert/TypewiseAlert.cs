using System;
using static TypewiseAlert.TypeWiseEnums;

namespace TypewiseAlert
{
  public class TypewiseAlert
  {
    
    public struct BatteryCharacter {
      public CoolingType coolingType;
      public string brand;
    }
    public static bool checkAndAlert(
        AlertTarget alertTarget, BatteryCharacter batteryChar, double temperatureInC) 
        {
            try
            {
              BreachType breachType = ClassifyTempBreach.classifyTemperatureBreach(
              batteryChar.coolingType, temperatureInC);
              if (alertTarget == AlertTarget.TO_CONTROLLER)
              {
                return ActionController.sendToController(breachType);
              }
              else
              {
                return ActionEmail.sendToEmail(breachType);
              }
            }
            catch(Exception)
            {
              return false;
            }      
        }
    }
}
