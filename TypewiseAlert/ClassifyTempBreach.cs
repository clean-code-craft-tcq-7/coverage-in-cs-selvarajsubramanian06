using System;
using System.Collections.Generic;
using static TypewiseAlert.TypeWiseEnums;

namespace TypewiseAlert
{
  public class ClassifyTempBreach{
    public static BreachType classifyTemperatureBreach(CoolingType coolingType, double temperatureInC) 
    {
        List<CoolingTypeParam> listOfCoolItems = new List<CoolingTypeParam>();
        listOfCoolItems.Add(new CoolingTypeParam() { Cooltype = CoolingType.PASSIVE_COOLING, LowerLimit = 0, UpperLimit = 35 });
        listOfCoolItems.Add(new CoolingTypeParam() { Cooltype = CoolingType.HI_ACTIVE_COOLING, LowerLimit = 0, UpperLimit = 45 });
        listOfCoolItems.Add(new CoolingTypeParam() { Cooltype = CoolingType.MED_ACTIVE_COOLING, LowerLimit = 0, UpperLimit = 40 });

        CoolingTypeParam OutputValue = listOfCoolItems.Find(m => m.Cooltype == coolingType);        
      
        return InferBreach.inferBreach(temperatureInC, OutputValue.LowerLimit, OutputValue.UpperLimit);
      }
    }
}    
