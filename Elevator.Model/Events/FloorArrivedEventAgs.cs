using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Elevator.Model.Enums;

namespace Elevator.Model.Events
{
  public class FloorArrivedEventAgs
  {
    public FloorArrivedEventAgs(int floorNumber, EnumRequestDirection enumRequestDirection)
    {
      FloorNumber = floorNumber;
      EnumRequestDirection = enumRequestDirection;
    }

    public int FloorNumber { get; set; }
    public EnumRequestDirection EnumRequestDirection { get; set; }
  }
}
