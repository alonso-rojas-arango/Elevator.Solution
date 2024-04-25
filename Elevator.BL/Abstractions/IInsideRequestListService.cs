using Elevator.Model.InsideRequestList;

namespace Elevator.BL.Abstractions
{
  public interface IInsideRequestListService
  {
    void Add(InsideRequestModel insideRequestModel);
    void NotifyGeneralChanges();
  }
}
