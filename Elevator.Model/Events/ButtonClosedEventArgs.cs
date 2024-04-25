using Elevator.Model.Enums;

namespace Elevator.Model.Events
{
  public class ButtonClosedEventArgs
  {
    public EnumDoorsState EnumDoorsState { get; set; }
    public ButtonClosedEventArgs(EnumDoorsState enumDoorsState)
    {
      EnumDoorsState = enumDoorsState;
    }
  }
}
