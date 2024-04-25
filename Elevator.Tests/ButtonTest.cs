using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Elevator.BL.Abstractions;
using Elevator.BL.Cabin;
using Elevator.BL.Common;
using Elevator.Tests.BaseConfiguration;

using Microsoft.Extensions.DependencyInjection;

namespace Elevator.Tests
{
  public class ButtonTest : BaseConfig
  {
    public ButtonTest() : base()
    {

    }

    [Fact]
    public void Button_Verify_Click_Method_Occurs()
    {
      //Arrange
      bool buttonHasBeenClicked = false;
      ButtonBl button = StaticServiceCollection.ServiceProvider.GetService<IButtonService>() as ButtonBl;
      button.ButtonPressed += (object sender, Model.Events.ButtonPressedEventArgs e) =>
      {
        buttonHasBeenClicked = true;
      };

      //Act
      button.Click();

      //Assert
      Assert.True(buttonHasBeenClicked);
    }

  }
}
