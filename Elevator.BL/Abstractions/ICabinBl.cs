using Elevator.Model.Events;
using Elevator.Model.InsideRequestList;


namespace Elevator.BL.Abstractions
{
  public interface ICabinBl
  {
    void ProcessRequest(InsideRequestModel insideRequestModel);
    public delegate void InsideRequestAddedHandler(object sender, InsideRequestAddedEventArgs e);
    public delegate void FloorArrivedHandler(object sender, FloorArrivedEventAgs e);
    public delegate void RequestProcessedHandler(object sender, RequestProcessedEventArgs e);
    void AddInsideRequest(InsideRequestModel insideRequestModel);
    void OpenDoors();
    void CloseDoors();
    void ProcessCurrentRequest();
    bool IsThereARequestAtTheCurrentFloor(int currentFloor);
  }
}
