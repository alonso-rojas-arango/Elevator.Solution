using Elevator.Model.Enums;

namespace Elevator.Model.Events
{
  public class ButtonPanelPressedEventArgs
  {
    public int FloorNumber { get; set; }
    public EnumPanelDirection Direction { get; set; }
    public ButtonPanelPressedEventArgs(int floorNumber, EnumPanelDirection direction)
    {
      FloorNumber = floorNumber;
      this.Direction = direction;
    }
  }
}
