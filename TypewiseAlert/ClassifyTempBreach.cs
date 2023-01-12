using System;
using static TypewiseAlert.TypeWiseEnums;

namespace TypewiseAlert
{
  public class ClassifyTempBreach{
    public static BreachType classifyTemperatureBreach(
          CoolingType coolingType, double temperatureInC) {
        int lowerLimit = 0;
        int upperLimit = 0;
        switch(coolingType) {
          case CoolingType.PASSIVE_COOLING:
            lowerLimit = 0;
            upperLimit = 35;
            break;
          /*case CoolingType.HI_ACTIVE_COOLING:
            lowerLimit = 0;
            upperLimit = 45;
            break;
          case CoolingType.MED_ACTIVE_COOLING:
            lowerLimit = 0;
            upperLimit = 40;
            break;*/
        }
        return inferBreach(temperatureInC, lowerLimit, upperLimit);
      }
    }
}    
