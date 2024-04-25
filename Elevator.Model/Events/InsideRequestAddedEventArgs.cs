using Elevator.Model.InsideRequestList;

namespace Elevator.Model.Events
{
  public class InsideRequestAddedEventArgs
  {
    public InsideRequestModel InsideRequestModel { get; set; }
    public InsideRequestAddedEventArgs(InsideRequestModel insideRequestModel)
    {
      InsideRequestModel = insideRequestModel;
    }
  }
}
