using Elevator.Model.Events;

namespace Elevator.BL.Abstractions
{
  public interface IButtonService
  {
    public delegate void ButtonPressedHandler(object sender, ButtonPressedEventArgs e);
    void Click();

  }
}
