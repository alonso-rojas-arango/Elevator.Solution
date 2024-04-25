using Elevator.BL.Abstractions;
using Elevator.Model.Cabin;
using Elevator.Model.Events;

using static Elevator.BL.Abstractions.IButtonService;

namespace Elevator.BL.Cabin
{
  public class ButtonBl : DashboardButtonModel, IButtonService
  {
    public event ButtonPressedHandler ButtonPressed;

    public void Click()
    {
      ButtonPressed.Invoke(this, new ButtonPressedEventArgs(ButtonNumber));
    }
  }
}
