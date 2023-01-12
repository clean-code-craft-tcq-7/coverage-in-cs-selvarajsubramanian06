using System;
using Xunit;
using static TypewiseAlert.TypeWiseEnums;

namespace TypewiseAlert.Test
{
  public class TypewiseAlertTest
  {
    [Fact]
    public void TestLimits()
    {
      Assert.True(InferBreach.inferBreach(12, 20, 30) == BreachType.TOO_LOW);
      Assert.True(InferBreach.inferBreach(5, 20, 30) == BreachType.TOO_LOW);
      Assert.True(InferBreach.inferBreach(28, 20, 30) == BreachType.NORMAL);
      Assert.True(InferBreach.inferBreach(24, 20, 30) == BreachType.NORMAL);
      Assert.True(InferBreach.inferBreach(35, 20, 30) == BreachType.TOO_HIGH);
      Assert.True(InferBreach.inferBreach(100, 20, 30) == BreachType.TOO_HIGH);

      Assert.True(ClassifyTempBreach.classifyTemperatureBreach(CoolingType.PASSIVE_COOLING, -1) == BreachType.TOO_LOW);
      Assert.True(ClassifyTempBreach.classifyTemperatureBreach(CoolingType.PASSIVE_COOLING, 30) == BreachType.NORMAL);
      Assert.True(ClassifyTempBreach.classifyTemperatureBreach(CoolingType.PASSIVE_COOLING, 50) == BreachType.TOO_HIGH);
      Assert.True(ClassifyTempBreach.classifyTemperatureBreach(CoolingType.HI_ACTIVE_COOLING, -5) == BreachType.TOO_LOW);
      Assert.True(ClassifyTempBreach.classifyTemperatureBreach(CoolingType.HI_ACTIVE_COOLING, 20) == BreachType.NORMAL);
      Assert.True(ClassifyTempBreach.classifyTemperatureBreach(CoolingType.HI_ACTIVE_COOLING, 60) == BreachType.TOO_HIGH);
      Assert.True(ClassifyTempBreach.classifyTemperatureBreach(CoolingType.MED_ACTIVE_COOLING, -2) == BreachType.TOO_LOW);
      Assert.True(ClassifyTempBreach.classifyTemperatureBreach(CoolingType.MED_ACTIVE_COOLING, 25) == BreachType.NORMAL);
      Assert.True(ClassifyTempBreach.classifyTemperatureBreach(CoolingType.MED_ACTIVE_COOLING, 70) == BreachType.TOO_HIGH);

      Assert.True(ActionEmail.sendToEmail(TypeWiseEnums.BreachType.NORMAL));
      Assert.True(ActionEmail.sendToEmail(TypeWiseEnums.BreachType.TOO_HIGH));
      Assert.True(ActionEmail.sendToEmail(TypeWiseEnums.BreachType.TOO_LOW));
/*
      Assert.True(ActionController.sendToController(TypeWiseEnums.BreachType.NORMAL));
      Assert.True(ActionController.sendToController(TypeWiseEnums.BreachType.TOO_HIGH));
      Assert.True(ActionController.sendToController(TypeWiseEnums.BreachType.TOO_LOW));*/
    }
  }
}
