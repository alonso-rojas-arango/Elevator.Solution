using Elevator.BL.Abstractions;
using Elevator.BL.Cabin;
using Elevator.BL.Common;
using Elevator.Model.Enums;
using Elevator.Model.Events;
using Elevator.Model.InsideRequestList;

using Microsoft.Extensions.DependencyInjection;

using static Elevator.BL.Abstractions.ICabinBl;

namespace Elevator.UI.CabinControls
{
  public partial class CabinControl : UserControl
  {
    public event InsideRequestAddedHandler InsideRequestAdded;
    public event FloorArrivedHandler FloorArrived;
    public CabinBl CabinBl { get; set; }

    public CabinControl()
    {
      InitializeComponent();
    }


    public void SetUp()
    {
      CabinBl = StaticServiceCollection.ServiceProvider.GetService<ICabinBl>() as CabinBl;
      CabinBl.PropertyChanged += CabinService_PropertyChanged;
    }
    public void ProcessDoors()
    {
      if (CabinBl!.EnumCabinState == Model.Enums.EnumCabinState.WaitingForDoorsToOpen)
      {
        this.panelDoorLeft.Width = 10;
        this.panelDoorRight.Width = 10;
        this.panelDoorRight.Left += 20;
        CabinBl.EnumCabinState = Model.Enums.EnumCabinState.DoorsOpen;
      }
      if (CabinBl!.EnumCabinState == Model.Enums.EnumCabinState.WaitingForDoorsToClose)
      {
        this.panelDoorLeft.Width = 55;
        this.panelDoorRight.Width = 55;
        this.panelDoorRight.Left -= 20;
        CabinBl.EnumCabinState = Model.Enums.EnumCabinState.DoorsClosed;
      }
    }

    private bool IsThereARequestAtTheCurrentFloor(int currentFloor)
    {
      return this.CabinBl.IsThereARequestAtTheCurrentFloor(currentFloor);
    }

    private InsideRequestModel GetCurrentInsideRequestFromList(int currentFloor)
    {
      return this.CabinBl.GetCurrentInsideRequestFromList(currentFloor);
    }

    private async void CabinService_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
      if (e.PropertyName == "InsideRequestListService")
      {
        var requestModel = StaticServiceCollection.ServiceProvider.GetService<InsideRequestModel>();
        if (InsideRequestAdded != null)
        {
          InsideRequestAdded.Invoke(this, new InsideRequestAddedEventArgs(requestModel));
        }
      }
      if (e.PropertyName == "EnumCabinState")
      {
        if (this.CabinBl.EnumCabinState == EnumCabinState.FloorArrived)
        {
          this.CabinBl.CurrentInsideRequestModel.RequestStatus = EnumRequestStatus.ReachingNextFloor;
        }
        this.ProcessDoors();
      }
      if (e.PropertyName == "CurrentFloor")
      {
        if (FloorArrived != null)
        {
          ProcessFloorArrived();
        }
      }
    }

    private void ProcessExistingRequest()
    {
      if (CabinBl.CurrentFloor == this.CabinBl.CurrentInsideRequestModel.TargetFloor)
      {
        this.CabinBl.CurrentInsideRequestModel.RequestStatus = EnumRequestStatus.Completed;
        CabinBl.EnumCabinState = EnumCabinState.DoorsClosed;
      }
      else
      {
        this.CabinBl.CurrentInsideRequestModel.RequestStatus = EnumRequestStatus.Paused;
        var transientRequest = GetCurrentInsideRequestFromList(CabinBl.CurrentFloor);
        if (transientRequest != null)
        {
          this.CabinBl.UpdateInsideRequestLitsService(transientRequest);
        }
      }
    }

    private async void ProcessFloorArrived()
    {
      FloorArrived.Invoke(this, new FloorArrivedEventAgs(this.CabinBl.CurrentFloor, this.CabinBl.CurrentInsideRequestModel.Direction));
      await Task.Delay(750);
      this.CabinBl.CurrentInsideRequestModel.RequestStatus = EnumRequestStatus.ReachingNextFloor;
      MoveCabin();
      await Task.Delay(750);
      if (IsThereARequestAtTheCurrentFloor(this.CabinBl.CurrentFloor))
      {
        ProcessExistingRequest();
        this.CabinBl.InsideRequestListService.NotifyGeneralChanges();
        CabinBl.EnumCabinState = EnumCabinState.WaitingForDoorsToOpen;
      }
      else
      {
        this.CabinBl.CurrentInsideRequestModel.RequestStatus = EnumRequestStatus.Pending;
        this.CabinBl.EnumCabinState = EnumCabinState.ResumingCurrentInsideRequest;
      }
      this.ProcessCurrentRequest();
    }

    private void MoveCabin()
    {
      var floorSize = 55;
      var currentTop = this.Top;
      if (this.CabinBl.CurrentInsideRequestModel.Direction == EnumRequestDirection.Up)
      {
        floorSize = -55;
      }
      this.Top += floorSize;
    }

    public void ProcessPanelButton(int floorNumber, EnumPanelDirection direction)
    {
      if (CabinBl.CurrentFloor == floorNumber)
      {
        return;
      }
      var insideRequestModel = new InsideRequestModel();
      insideRequestModel.CurrentFloor = CabinBl.CurrentFloor;
      insideRequestModel.RequestStatus = EnumRequestStatus.Pending;
      insideRequestModel.TargetFloor = floorNumber;
      insideRequestModel.EnumPanelDirection = direction;
      insideRequestModel.EnumRequestType = EnumRequestType.FromPanel;
      CabinBl.AddInsideRequestFromPanel(insideRequestModel);
    }

    public void ProcessDashboardButtonClick(int floorNumber)
    {
      if (CabinBl.CurrentFloor == floorNumber)
      {
        return;
      }
      (CabinBl.DashboardButtons[floorNumber - 1] as ButtonBl)?.Click();
    }

    private void CabinControl_Click(object sender, EventArgs e)
    {
    }

    internal void Close()
    {
      if (this.CabinBl.EnumCabinState == Model.Enums.EnumCabinState.DoorsOpen)
        this.CabinBl.CloseDoors();
    }

    internal void Open()
    {
      if (this.CabinBl.EnumCabinState == Model.Enums.EnumCabinState.DoorsClosed)
        this.CabinBl.OpenDoors();
    }

    public void ProcessCurrentRequest()
    {
      this.CabinBl.ProcessCurrentRequest();
    }
  }
}
