using Elevator.Model.Abstractions;
using Elevator.Model.Enums;

namespace Elevator.Model.InsideRequestList
{
  public class InsideRequestModel : AbstractPropertyChanged
  {
    public int TargetFloor { get; set; }
    public int CurrentFloor { get; set; }
    public EnumRequestStatus RequestStatus { get; set; }
    public EnumRequestDirection Direction { get; set; }
    public EnumRequestType EnumRequestType { get; set; } = EnumRequestType.FromDashboard;
    public EnumPanelDirection EnumPanelDirection { get; set; }

  }
}
