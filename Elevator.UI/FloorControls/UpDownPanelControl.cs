using Elevator.Model.Events;

using static Elevator.BL.Abstractions.ICabinBl;

namespace Elevator.UI.FloorControls
{
  public partial class UpDownPanelControl : UserControl
  {
    public event ButtonPanelPressedEventHandler ButtonPanelPressed;
    public delegate void ButtonPanelPressedEventHandler(object sender, ButtonPanelPressedEventArgs e);
    private int FloorNumber;
    public UpDownPanelControl()
    {
      InitializeComponent();
    }

    private void buttonUp_Click(object sender, EventArgs e)
    {
      if (ButtonPanelPressed != null)
      {
        ButtonPanelPressed.Invoke(this, new ButtonPanelPressedEventArgs(FloorNumber, Model.Enums.EnumPanelDirection.Up));
      }
    }

    private void buttonDown_Click(object sender, EventArgs e)
    {
      if (ButtonPanelPressed != null)
      {
        ButtonPanelPressed.Invoke(this, new ButtonPanelPressedEventArgs(FloorNumber, Model.Enums.EnumPanelDirection.Down));
      }
    }

    public void SetUp(int floorNumber)
    {
      FloorNumber = floorNumber;
      buttonDown.Visible = floorNumber != 1;
      buttonUp.Visible = floorNumber != 5;
      if (floorNumber == 1 || floorNumber == 5)
      {
        this.Height = 16;
      }
      if (floorNumber == 5)
      {
        buttonDown.Top = 0;
      }
    }
  }
}
