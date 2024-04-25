using Elevator.Tests.DependencyInjection;

namespace Elevator.Tests.BaseConfiguration
{
  public class BaseConfig
  {
    public BaseConfig()
    {
      ManualDI.SetUpDI();
    }
  }
}
