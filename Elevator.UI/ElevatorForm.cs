using Elevator.BL.Abstractions;
using Elevator.BL.Cabin;
using Elevator.BL.Common;
using Elevator.UI.FloorControls;

using Microsoft.Extensions.DependencyInjection;

namespace Elevator.UI
{
  public partial class ElevatorForm : Form
  {
    private CabinBl cabinService { get; set; }
    public InsideRequestListBl InsideRequestListService { get; set; }
    public ElevatorForm(ICabinBl cabinService)
    {
      InitializeComponent();
      this.cabinService = cabinService as CabinBl;
      InsideRequestListService = StaticServiceCollection.ServiceProvider.GetService<InsideRequestListBl>();
      InsideRequestListService.PropertyChanged += InsideRequestListService_PropertyChanged;
    }

    private void InsideRequestListService_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
      if (e.PropertyName == "InsideRequestListService")
      {
        BindInsideRequestGrid();
      }
    }

    private void BindInsideRequestGrid()
    {
      var datagridSource = new BindingSource();
      datagridSource.DataSource = InsideRequestListService;
      this.GridViewInsideRequests.DataSource = datagridSource;
      this.GridViewInsideRequests.Columns[1].Visible = false;
      this.GridViewInsideRequests.Columns[this.GridViewInsideRequests.Columns.Count - 1].Visible = false;
    }

    private void ElevatorForm_Load(object sender, EventArgs e)
    {
      BindInsideRequestGrid();
      cabinControl1.SetUp();
      cabinControl1.FloorArrived += CabinControl1_FloorArrived;
      buttonDashboardControl1.SetUp();
      SetUpFloorPanelButtons();
    }

    private void SetUpFloorPanelButtons()
    {
      for (int i = 1; i < 6; i++)
      {
        var controlName = "upDownPanelControl" + i.ToString();
        var upDownControl = this
          .Controls
          .Find(controlName, true)[0] as UpDownPanelControl;

        upDownControl.SetUp(i);
        upDownControl.ButtonPanelPressed += UpDownControl_ButtonPanelPressed;
      }
    }

    private void UpDownControl_ButtonPanelPressed(object sender, Model.Events.ButtonPanelPressedEventArgs e)
    {
      cabinControl1.ProcessPanelButton(e.FloorNumber, e.Direction);
    }

    private async void CabinControl1_FloorArrived(object sender, Model.Events.FloorArrivedEventAgs e)
    {
      buttonDashboardControl1.UpdateFloorPanel(e.FloorNumber.ToString(), e.EnumRequestDirection);
    }

    private void buttonDashboardControl1_FloorButtonPressed(object sender, Model.Events.ButtonPressedEventArgs e)
    {
      cabinControl1.ProcessDashboardButtonClick(e.ButtonNumber);
    }

    private void buttonDashboardControl1_ButtonClosePressed(object sender, Model.Events.ButtonClosedEventArgs e)
    {
      if (e.EnumDoorsState == Model.Enums.EnumDoorsState.Close)
      {
        this.cabinControl1.Close();
        this.cabinControl1.ProcessCurrentRequest();
      }
      if (e.EnumDoorsState == Model.Enums.EnumDoorsState.Open)
      {
        this.cabinControl1.Open();
      }
    }
  }
}
