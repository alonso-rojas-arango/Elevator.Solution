using Elevator.Model.Enums;
using Elevator.Model.Events;

namespace Elevator.UI.CabinControls
{
  public partial class ButtonDashboardControl : UserControl
  {
    public delegate void ButtonPressedHandler(object sender, ButtonPressedEventArgs e);
    public event ButtonPressedHandler FloorButtonPressed;

    public delegate void ButtonClosedHandler(object sender, ButtonClosedEventArgs e);
    public event ButtonClosedHandler ButtonClosePressed;
    public ButtonDashboardControl()
    {
      InitializeComponent();
    }

    private void ButtonDashboardControl_Load(object sender, EventArgs e)
    {
    }

    private void InvokeFloorButtonPressed(int floorNumber)
    {
      if (FloorButtonPressed != null)
      {
        FloorButtonPressed.Invoke(this, new ButtonPressedEventArgs(floorNumber));
      }
    }
    private void label1_Click(object sender, EventArgs e)
    {
      InvokeFloorButtonPressed(1);
    }

    private void label2_Click(object sender, EventArgs e)
    {
      InvokeFloorButtonPressed(2);
    }

    private void label3_Click(object sender, EventArgs e)
    {
      InvokeFloorButtonPressed(3);
    }

    private void label4_Click(object sender, EventArgs e)
    {
      InvokeFloorButtonPressed(4);
    }

    private void label5_Click(object sender, EventArgs e)
    {
      InvokeFloorButtonPressed(5);
    }

    public void UpdateFloorPanel(string floorNumber, EnumRequestDirection requestDirection)
    {
      labelFloor.Text = floorNumber;
      labelDirection.Text = requestDirection.ToString();
    }

    private void labelClose_Click(object sender, EventArgs e)
    {
      if (ButtonClosePressed != null)
      {
        ButtonClosePressed.Invoke(this, new ButtonClosedEventArgs(EnumDoorsState.Close));
      }
    }

    private void labelOpen_Click(object sender, EventArgs e)
    {
      if (ButtonClosePressed != null)
      {
        ButtonClosePressed.Invoke(this, new ButtonClosedEventArgs(EnumDoorsState.Open));
      }
    }

    internal void SetUp()
    {
      UpdateFloorPanel("1", EnumRequestDirection.Up);
    }
  }
}
