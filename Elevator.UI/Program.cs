using Elevator.BL.Common;
using Elevator.BL.ServiceRegistration;

using Microsoft.Extensions.DependencyInjection;

namespace Elevator.UI
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      ApplicationConfiguration.Initialize();

      var serviceCollection = new ServiceCollection();
      ConfigureServices(serviceCollection);
      var _serviceProvider = serviceCollection.BuildServiceProvider();
      StaticServiceCollection.ServiceProvider = _serviceProvider;

      Application.Run(StaticServiceCollection.ServiceProvider.GetService<ElevatorForm>());
    }

    private static void ConfigureServices(IServiceCollection services)
    {
      services.AddInfrastructureServices();
      services.AddTransient<ElevatorForm>();
    }
  }
}