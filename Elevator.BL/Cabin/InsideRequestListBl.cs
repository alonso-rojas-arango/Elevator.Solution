using Elevator.BL.Abstractions;
using Elevator.BL.Common;
using Elevator.Model.InsideRequestList;

using Microsoft.Extensions.DependencyInjection;

namespace Elevator.BL.Cabin
{
  public class InsideRequestListBl : InsideRequestListModel, IInsideRequestListService
  {
    public InsideRequestListBl() : base(StaticServiceCollection.ServiceProvider.GetService<List<InsideRequestModel>>())
    {
      Clear();
    }
    public void Add(InsideRequestModel insideRequestModel)
    {
      base.Add(insideRequestModel);
      OnPropertyChanged("InsideRequestListService");
    }

    public void NotifyGeneralChanges()
    {
      OnPropertyChanged("InsideRequestListService");
    }
  }
}
