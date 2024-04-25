namespace Elevator.Model.Events
{
  public class ButtonPressedEventArgs
  {
    public int ButtonNumber { get; set; }
    public ButtonPressedEventArgs(int buttonNumber)
    {
      ButtonNumber = buttonNumber;
    }
  }
}
