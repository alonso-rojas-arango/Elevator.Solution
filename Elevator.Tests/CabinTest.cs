using Elevator.BL.Abstractions;
using Elevator.BL.Cabin;
using Elevator.BL.Common;
using Elevator.Model.Cabin;
using Elevator.Model.Enums;
using Elevator.Model.InsideRequestList;
using Elevator.Tests.BaseConfiguration;

using Microsoft.Extensions.DependencyInjection;

namespace Elevator.Tests
{
  /// <summary>
  /// Even though there is an XUnit dependency injection alternative from nuget, I created manual Dependency Injection for demo purposes
  /// This test project uses dependency injection when executing the program
  /// When the tests load, the SetUpDI method from the parent BaseConfig class is called
  /// The set up of the Services collection happens in the AddInfrastructureServices file
  /// </summary>
  public class CabinTest : BaseConfig
  {
    public CabinTest() : base()
    {

    }

    [Fact]
    public void Cabin_Create_DashboardButtons()
    {
      //Arrange
      CabinBl cabin = StaticServiceCollection.ServiceProvider.GetService<ICabinBl>() as CabinBl;

      //Act
      var dashboardButtons = cabin.DashboardButtons;

      //Assert
      Assert.Equal(5, dashboardButtons.Count());
    }

    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    public void Cabin_Move_To_FloorNumber(int floorNumber)
    {
      //Arrange
      CabinBl cabin = StaticServiceCollection.ServiceProvider.GetService<ICabinBl>() as CabinBl;
      InsideRequestListBl insideRequestListBl = StaticServiceCollection.ServiceProvider.GetService<InsideRequestListBl>();

      //Act
      insideRequestListBl.Add(new Model.InsideRequestList.InsideRequestModel()
      {
        CurrentFloor = 1,
        Direction = Model.Enums.EnumRequestDirection.Up,
        EnumPanelDirection = Model.Enums.EnumPanelDirection.None,
        EnumRequestType = Model.Enums.EnumRequestType.FromDashboard,
        RequestStatus = Model.Enums.EnumRequestStatus.Pending,
        TargetFloor = floorNumber
      });
      cabin.EnumCabinState = Model.Enums.EnumCabinState.DoorsClosed;
      cabin.ProcessCurrentRequest();

      //Assert
      Assert.Equal(floorNumber, cabin.CurrentFloor);
    }

    [Fact]
    public void Cabin_Do_Not_Move_When_Same_Floor_Number_Requested()
    {
      int floorNumber = 1;
      //Arrange
      CabinBl cabin = StaticServiceCollection.ServiceProvider.GetService<ICabinBl>() as CabinBl;
      InsideRequestListBl insideRequestListBl = StaticServiceCollection.ServiceProvider.GetService<InsideRequestListBl>();

      //Act
      insideRequestListBl.Add(new Model.InsideRequestList.InsideRequestModel()
      {
        CurrentFloor = 1,
        Direction = Model.Enums.EnumRequestDirection.Up,
        EnumPanelDirection = Model.Enums.EnumPanelDirection.None,
        EnumRequestType = Model.Enums.EnumRequestType.FromDashboard,
        RequestStatus = Model.Enums.EnumRequestStatus.Pending,
        TargetFloor = floorNumber
      });
      cabin.EnumCabinState = Model.Enums.EnumCabinState.DoorsClosed;
      cabin.ProcessCurrentRequest();

      //Assert
      Assert.Equal(floorNumber, cabin.CurrentFloor);
    }

    [Theory]
    [InlineData(5)]
    [InlineData(4)]
    [InlineData(3)]
    [InlineData(2)]
    public void Cabin_Verify_Elevator_Does_Not_Process_A_Request_When_Is_Going_In_A_Different_Direction(int currentFloor)
    {
      int targetFloorNumber = 1;

      //Arrange
      CabinBl cabin = StaticServiceCollection.ServiceProvider.GetService<ICabinBl>() as CabinBl;
      InsideRequestListBl insideRequestListBl = StaticServiceCollection.ServiceProvider.GetService<InsideRequestListBl>();

      //Act
      var request = StaticServiceCollection.ServiceProvider.GetService<InsideRequestModel>();
      request.CurrentFloor = currentFloor;
      request.Direction = Model.Enums.EnumRequestDirection.Up;
      request.EnumPanelDirection = Model.Enums.EnumPanelDirection.None;
      request.EnumRequestType = Model.Enums.EnumRequestType.FromDashboard;
      request.RequestStatus = Model.Enums.EnumRequestStatus.Pending;
      request.TargetFloor = targetFloorNumber;

      cabin.CurrentInsideRequestModel = request;
      cabin.ProcessRequest(request);

      //Assert
      Assert.Equal(currentFloor, request.CurrentFloor);
    }

    [Theory]
    [InlineData(5)]
    [InlineData(4)]
    [InlineData(3)]
    [InlineData(2)]
    public void Cabin_Verify_Elevator_Process_Requests_When_Is_Going_In_The_Same_Direction(int currentFloor)
    {
      int targetFloorNumber = 1;

      //Arrange
      CabinBl cabin = StaticServiceCollection.ServiceProvider.GetService<ICabinBl>() as CabinBl;
      InsideRequestListBl insideRequestListBl = StaticServiceCollection.ServiceProvider.GetService<InsideRequestListBl>();
      cabin.CurrentFloor = currentFloor;

      //Act
      var request = StaticServiceCollection.ServiceProvider.GetService<InsideRequestModel>();
      request.CurrentFloor = currentFloor;
      request.Direction = Model.Enums.EnumRequestDirection.Down;
      request.EnumPanelDirection = Model.Enums.EnumPanelDirection.None;
      request.EnumRequestType = Model.Enums.EnumRequestType.FromDashboard;
      request.RequestStatus = Model.Enums.EnumRequestStatus.Pending;
      request.TargetFloor = targetFloorNumber;

      insideRequestListBl.Add(request);
      cabin.CurrentInsideRequestModel = request;
      cabin.ProcessRequest(request);

      //Assert
      Assert.Equal(targetFloorNumber, cabin.CurrentFloor);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(5)]
    public void Cabin_Does_Not_Movw_When_Doors_Are_Open(int floorNumber)
    {
      int currentFloor = 1;
      //Arrange
      CabinBl cabin = StaticServiceCollection.ServiceProvider.GetService<ICabinBl>() as CabinBl;
      InsideRequestListBl insideRequestListBl = StaticServiceCollection.ServiceProvider.GetService<InsideRequestListBl>();

      //Act
      insideRequestListBl.Add(new Model.InsideRequestList.InsideRequestModel()
      {
        CurrentFloor = currentFloor,
        Direction = Model.Enums.EnumRequestDirection.Up,
        EnumPanelDirection = Model.Enums.EnumPanelDirection.None,
        EnumRequestType = Model.Enums.EnumRequestType.FromDashboard,
        RequestStatus = Model.Enums.EnumRequestStatus.Pending,
        TargetFloor = floorNumber
      });
      cabin.EnumCabinState = Model.Enums.EnumCabinState.DoorsOpen;
      cabin.ProcessCurrentRequest();

      //Assert
      Assert.Equal(currentFloor, cabin.CurrentFloor);
    }
  }
}