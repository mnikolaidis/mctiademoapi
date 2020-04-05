using System;
using Xunit;
using DemoAPI.Controllers;
using System.Linq;

namespace DemoAPI.Tests
{
    public class UnitTest1
    {
        private WeatherForecastController controller = new WeatherForecastController(null);

        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void GetWeeklyForecast()
        {
            var count = controller.Get().Count();
            Assert.Equal(4, count);
        }
    }
}
