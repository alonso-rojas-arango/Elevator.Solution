using Elevator.Model.InsideRequestList;

namespace Elevator.Model.Events
{
  public class RequestProcessedEventArgs
  {
    public InsideRequestModel InsideRequestModel { get; set; }
    public RequestProcessedEventArgs(InsideRequestModel insideRequestModel)
    {
      InsideRequestModel = insideRequestModel;
    }
  }
}
