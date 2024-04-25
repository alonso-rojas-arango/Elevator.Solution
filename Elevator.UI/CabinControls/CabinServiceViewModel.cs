using Elevator.BL.Abstractions;
using Elevator.BL.Cabin;

namespace Elevator.UI.CabinControls
{
  public class CabinServiceViewModel
  {
    public CabinBl CabinService { get; set; }
    public CabinServiceViewModel(ICabinBl cabinService)
    {
      this.CabinService = cabinService as CabinBl;
    }
  }
}
