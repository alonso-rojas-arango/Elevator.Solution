using Elevator.BL.Abstractions;
using Elevator.BL.Cabin;
using Elevator.Model.Cabin;
using Elevator.Model.InsideRequestList;

using Microsoft.Extensions.DependencyInjection;

namespace Elevator.BL.ServiceRegistration
{
  public static class BusinessLogicServiceRegistration
  {
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
      services.AddTransient<DashboardButtonModel>();
      services.AddTransient<List<DashboardButtonModel>>();
      services.AddTransient<InsideRequestModel>();
      services.AddSingleton<InsideRequestListModel>();
      services.AddSingleton<List<InsideRequestModel>>();
      services.AddSingleton<InsideRequestListBl>();

      services.AddTransient<CabinModel>();
      services.AddTransient<IButtonService, ButtonBl>();
      services.AddTransient<ICabinBl, CabinBl>();
      return services;
    }
  }
}
