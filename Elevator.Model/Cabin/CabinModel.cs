using Elevator.Model.Abstractions;
using Elevator.Model.Enums;
using Elevator.Model.InsideRequestList;

namespace Elevator.Model.Cabin
{
  public class CabinModel : AbstractPropertyChanged
  {
    private int currentFloor = 1;
    private List<DashboardButtonModel> dashboardButtons;

    public List<DashboardButtonModel> DashboardButtons
    {
      get { return dashboardButtons; }
      set { dashboardButtons = value; }
    }

    private InsideRequestModel currentInsideRequestModel;

    public InsideRequestModel CurrentInsideRequestModel
    {
      get { return currentInsideRequestModel; }
      set
      {
        SetField(ref currentInsideRequestModel, value, "CurrentInsideRequestModel");
      }
    }


    public int CurrentFloor
    {
      get { return currentFloor; }
      set
      {
        currentFloor = value;
        OnPropertyChanged("CurrentFloor");
      }
    }

    private EnumCabinState enumCabinState;

    public EnumCabinState EnumCabinState
    {
      get { return enumCabinState; }
      set
      {
        enumCabinState = value;
        OnPropertyChanged("EnumCabinState");
      }
    }


  }
}
