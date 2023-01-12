using System;
using Xunit;
using static TypewiseAlert.TypeWiseEnums;

namespace TypewiseAlert.Test
{
  public class TypewiseAlertTest
  {
    [Fact]
    public void InfersBreachAsPerLimits()
    {
      Assert.True(InferBreach.inferBreach(12, 20, 30) == BreachType.TOO_LOW);
      Assert.True(InferBreach.inferBreach(5, 20, 30) == BreachType.TOO_LOW);
      Assert.True(InferBreach.inferBreach(8, 20, 30) == BreachType.TOO_LOW);

      Assert.True(InferBreach.inferBreach(26, 20, 30) == BreachType.NORMAL);
      Assert.True(InferBreach.inferBreach(28, 20, 30) == BreachType.NORMAL);
      Assert.True(InferBreach.inferBreach(24, 20, 30) == BreachType.NORMAL);

      Assert.True(InferBreach.inferBreach(40, 20, 30) == BreachType.TOO_HIGH);
      Assert.True(InferBreach.inferBreach(35, 20, 30) == BreachType.TOO_HIGH);
      Assert.True(InferBreach.inferBreach(100, 20, 30) == BreachType.TOO_HIGH);
    }
  }
}
