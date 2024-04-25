namespace Elevator.Model.Enums
{
  public enum EnumCabinState
  {
    InsideRequestReceived,
    InsideRequestProcessStarted,
    FloorArrived,
    WaitingForInsideRequestToResume,
    VerifyingIfFloorIsRequested,
    ResumingCurrentInsideRequest,
    WaitingForDoorsToClose,
    DoorsClosed,
    WaitingForDoorsToOpen,
    DoorsOpen
  }
}
