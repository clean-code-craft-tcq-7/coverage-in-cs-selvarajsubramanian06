using System;
using System.Collections.Generic;
using static TypewiseAlert.TypeWiseEnums;

namespace TypewiseAlert
{
  public class ClassifyTempBreach{
    public static BreachType classifyTemperatureBreach(CoolingType coolingType, double temperatureInC) 
    {
        List<CoolingTypeParam> listOfCoolItems = new List<CoolingTypeParam>();
        listOfCoolItems.Add(new CoolingTypeParam() { Cooltype = CoolingType.PASSIVE_COOLING, LowerLimit = Constants.PassiveLowLimit, UpperLimit = Constants.PassiveHighLimit });
        listOfCoolItems.Add(new CoolingTypeParam() { Cooltype = CoolingType.HI_ACTIVE_COOLING, LowerLimit = Constants.HiActiveLowLimit, UpperLimit = Constants.HiActiveHighLimit });
        listOfCoolItems.Add(new CoolingTypeParam() { Cooltype = CoolingType.MED_ACTIVE_COOLING, LowerLimit = Constants.MedActiveLowLimit, UpperLimit = Constants.MedActiveHighLimit });

        CoolingTypeParam OutputValue = listOfCoolItems.Find(m => m.Cooltype == coolingType);        
      
        return InferBreach.inferBreach(temperatureInC, OutputValue.LowerLimit, OutputValue.UpperLimit);
      }
    }
}    
