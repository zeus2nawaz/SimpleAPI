using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {

        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void GetReturnsMyName()
        {
        //Given
        var returnvalue = controller.Get(1);
        //When
              
        //Then
        Assert.Equal("Nawaz", returnvalue.Value);  

        }

        [Fact]
        public void Test1()
        {

        }
    }
}
