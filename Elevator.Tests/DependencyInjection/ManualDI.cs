

using Elevator.BL.Common;
using Elevator.BL.ServiceRegistration;

using Microsoft.Extensions.DependencyInjection;

namespace Elevator.Tests.DependencyInjection
{
  public static class ManualDI
  {
    public static void SetUpDI()
    {
      var serviceCollection = new ServiceCollection();
      ConfigureServices(serviceCollection);
      var _serviceProvider = serviceCollection.BuildServiceProvider();
      StaticServiceCollection.ServiceProvider = _serviceProvider;
    }

    private static void ConfigureServices(IServiceCollection services)
    {
      services.AddInfrastructureServices();
    }

  }
}
