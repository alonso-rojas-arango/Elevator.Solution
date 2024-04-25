using Elevator.BL.Abstractions;
using Elevator.BL.Common;
using Elevator.Model.Cabin;
using Elevator.Model.Enums;
using Elevator.Model.Events;
using Elevator.Model.InsideRequestList;

using Microsoft.Extensions.DependencyInjection;

using static Elevator.BL.Abstractions.ICabinBl;

namespace Elevator.BL.Cabin
{
  public class CabinBl : CabinModel, ICabinBl
  {
    public InsideRequestListBl InsideRequestListService { get; set; }

    private void SetInsideRequestDirection(InsideRequestModel insideRequestModel)
    {
      if (insideRequestModel.TargetFloor > CurrentFloor)
      {
        insideRequestModel.Direction = Model.Enums.EnumRequestDirection.Up;
      }
      else
      {
        insideRequestModel.Direction = Model.Enums.EnumRequestDirection.Down;
      }
    }

    public void AddInsideRequestFromPanel(InsideRequestModel insideRequestModel)
    {
      SetInsideRequestListService();
      SetInsideRequestDirection(insideRequestModel);
      InsideRequestListService?.Add(insideRequestModel);
    }

    public void AddInsideRequest(InsideRequestModel insideRequestModel)
    {
      SetInsideRequestListService();
      SetInsideRequestDirection(insideRequestModel);
      InsideRequestListService?.Add(insideRequestModel);
    }

    private void MoveFloor(EnumRequestDirection Direction)
    {
      if (Direction == EnumRequestDirection.Up)
      {
        CurrentFloor += 1;
      }
      else
      {
        CurrentFloor -= 1;
      }
      EnumCabinState = EnumCabinState.FloorArrived;
    }

    public void ProcessRequest(InsideRequestModel insideRequestModel)
    {
      while (CurrentInsideRequestModel.RequestStatus != EnumRequestStatus.ReachingNextFloor && CurrentFloor != insideRequestModel.TargetFloor)
      {
        SetInsideRequestDirection(insideRequestModel);
        MoveFloor(insideRequestModel.Direction);
      }
      if (CurrentFloor == insideRequestModel.TargetFloor)
      {
        CurrentInsideRequestModel.RequestStatus = EnumRequestStatus.Completed;
        if (InsideRequestListService != null)
          InsideRequestListService.NotifyGeneralChanges();
      }
    }

    public CabinBl()
    {
      InitializeDashboardButtonsCollection();
      EnumCabinState = Model.Enums.EnumCabinState.DoorsOpen;
    }

    private void InitializeDashboardButtonsCollection()
    {
      DashboardButtons = StaticServiceCollection.ServiceProvider.GetService<List<DashboardButtonModel>>();
      DashboardButtons.Clear();

      for (int i = 0; i < 5; i++)
      {
        var db = StaticServiceCollection.ServiceProvider.GetService<IButtonService>() as ButtonBl;
        db.ButtonNumber = i + 1;
        db.ButtonPressed += Db_ButtonPressed;
        DashboardButtons.Add(db);
      }
    }

    private void SetInsideRequestListService()
    {
      if (InsideRequestListService == null)
      {
        InsideRequestListService = StaticServiceCollection.ServiceProvider.GetService<InsideRequestListBl>();
      }
    }

    public InsideRequestModel GetCurrentInsideRequestFromList(int currentFloor)
    {
      SetInsideRequestListService();
      return InsideRequestListService
        .Where(p => p.TargetFloor == currentFloor && p.RequestStatus == EnumRequestStatus.Pending)
        .FirstOrDefault();
    }

    public void UpdateInsideRequestLitsService(InsideRequestModel insideRequestModel)
    {
      SetInsideRequestListService();
      var index = InsideRequestListService
        .IndexOf(insideRequestModel);

      if (index > -1)
      {
        InsideRequestListService[index].RequestStatus = EnumRequestStatus.Completed;
      }
    }

    public bool ThereArePendingRequestsInDifferentDirection(EnumRequestDirection requestDirection, int currentFloor, InsideRequestModel pendingPanelRequest)
    {
      var pendingRequest = InsideRequestListService
        .Where(p =>
        p.EnumRequestType == EnumRequestType.FromDashboard
        && p.TargetFloor != this.CurrentFloor
        && p.Direction.ToString() != pendingPanelRequest.EnumPanelDirection.ToString()
        && p.RequestStatus != EnumRequestStatus.Completed)
        .FirstOrDefault();
      return pendingRequest != null;
    }

    public bool IsThereARequestAtTheCurrentFloor(int currentFloor)
    {
      SetInsideRequestListService();
      var pendingRequest = InsideRequestListService
        .Where(p =>
        (p.RequestStatus == EnumRequestStatus.Pending || p.RequestStatus == EnumRequestStatus.ReachingNextFloor)
        && p.TargetFloor == currentFloor)
        .FirstOrDefault();

      if (pendingRequest != null)
      {
        if (pendingRequest.EnumRequestType == EnumRequestType.FromPanel)
        {
          var direction = pendingRequest.Direction == EnumRequestDirection.Up ? EnumRequestDirection.Up : EnumRequestDirection.Down;


          if (ThereArePendingRequestsInDifferentDirection(direction, currentFloor, pendingRequest))
          {
            return false;
          }
          else
          {
            return true;
          }
        }
      }
      return pendingRequest != null;
    }

    private bool VerifyInsideRequestDoesNotExist(ButtonPressedEventArgs e)
    {
      SetInsideRequestListService();

      if (InsideRequestListService
        .Where(r => r.TargetFloor == e.ButtonNumber && r.RequestStatus != EnumRequestStatus.Completed)
        .FirstOrDefault() == null)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    private InsideRequestModel CreateRequestModel(int buttonNUmber)
    {
      var requestModel = StaticServiceCollection.ServiceProvider.GetService<InsideRequestModel>();
      requestModel.CurrentFloor = CurrentFloor;
      requestModel.RequestStatus = Model.Enums.EnumRequestStatus.Pending;
      requestModel.TargetFloor = buttonNUmber;
      return requestModel;
    }

    private void Db_ButtonPressed(object sender, ButtonPressedEventArgs e)
    {
      if (!VerifyInsideRequestDoesNotExist(e))
      {
        return;
      }
      var insideRequestModel = CreateRequestModel(e.ButtonNumber);
      AddInsideRequest(insideRequestModel);
      ProcessCurrentRequest();
    }

    public void OpenDoors()
    {
      EnumCabinState = Model.Enums.EnumCabinState.WaitingForDoorsToOpen;
    }

    public void CloseDoors()
    {
      EnumCabinState = Model.Enums.EnumCabinState.WaitingForDoorsToClose;
    }

    private void SetDefaultInsideRequestModel()
    {
      if (InsideRequestListService.Count >= 0)
      {
        CurrentInsideRequestModel = InsideRequestListService
          .Where(p => p.RequestStatus == EnumRequestStatus.Pending)
          .FirstOrDefault();
      }
    }

    private void SetInsideRequestModelForTargetFloor()
    {
      var request = InsideRequestListService
            .Where(p => p.RequestStatus == EnumRequestStatus.Pending && p.Direction == CurrentInsideRequestModel.Direction)
            .FirstOrDefault();
      this.EnumCabinState = Model.Enums.EnumCabinState.ResumingCurrentInsideRequest;

      if (request != null)
      {
        CurrentInsideRequestModel = request;
      }
      else
      {
        CurrentInsideRequestModel = InsideRequestListService
        .Where(p => p.RequestStatus == EnumRequestStatus.Pending)
        .FirstOrDefault();
        this.EnumCabinState = Model.Enums.EnumCabinState.DoorsClosed;
      }
    }

    private void EnsureCurrentInsideRequestModelExists()
    {
      SetInsideRequestListService();

      if (CurrentInsideRequestModel == null)
      {
        SetDefaultInsideRequestModel();
      }
      else
      {
        if (CurrentInsideRequestModel.TargetFloor == CurrentFloor)
        {
          SetInsideRequestModelForTargetFloor();

        }
        else
        {
          this.EnumCabinState = Model.Enums.EnumCabinState.ResumingCurrentInsideRequest;
        }

      }
    }

    public void SetNextInsideRequestModel()
    {
      CurrentInsideRequestModel = null;
      EnsureCurrentInsideRequestModelExists();
    }

    public void ProcessCurrentRequest()
    {
      if (this.EnumCabinState != Model.Enums.EnumCabinState.DoorsClosed && this.EnumCabinState != Model.Enums.EnumCabinState.ResumingCurrentInsideRequest)
      {
        return;
      }

      EnsureCurrentInsideRequestModelExists();
      if (CurrentInsideRequestModel != null)
      {
        this.CurrentInsideRequestModel.RequestStatus = Model.Enums.EnumRequestStatus.Processing;
        InsideRequestListService.NotifyGeneralChanges();
        this.ProcessRequest(this.CurrentInsideRequestModel);
      }
    }
  }
}
