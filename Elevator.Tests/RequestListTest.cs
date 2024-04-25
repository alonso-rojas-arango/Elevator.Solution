using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Elevator.BL.Abstractions;
using Elevator.BL.Cabin;
using Elevator.BL.Common;
using Elevator.Model.InsideRequestList;
using Elevator.Tests.BaseConfiguration;

using Microsoft.Extensions.DependencyInjection;

namespace Elevator.Tests
{
  public class RequestListTest : BaseConfig
  {
    public RequestListTest() : base()
    {

    }
    [Fact]
    public void RequestListVerify_Property_Change_Notifications_Ocurre_Correctly()
    {
      var propertyChangedFound = false;
      //Arrange
      InsideRequestListBl insideRequestListBl = StaticServiceCollection.ServiceProvider.GetService<InsideRequestListBl>();

      //Act
      (insideRequestListBl as INotifyPropertyChanged).PropertyChanged += (object? sender, PropertyChangedEventArgs e) =>
      {
        if (e.PropertyName == "InsideRequestListService")
        {
          propertyChangedFound = true;
        }
      };

      insideRequestListBl.Add(new InsideRequestModel());

      //Assert
      Assert.True(propertyChangedFound);
    }

  }
}
