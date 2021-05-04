using DTNLightningAlert.Core.WorkerService;
using System;
using Xunit;

namespace DTNLightningAlert.Core.Test
{
    public class CalculationWorkerServiceTest
    {
        [Fact]
        public void IsValidCalculatedStrikeTimeTest()
        {
            //Arrange
            DateTime? date = null;

            //Act
            //var result = CalculationsWorkerService.IsValidCalculatedStrikeTime(date);

            //Assert
            //Assert.False(result);
        }

        [Fact]
        public void CalculateQuadKeyTest()
        {
            //Arrange
            double? latitude = null;
            double? longitude = null;

            //Act
            var result = CalculationsWorkerService.CalculateQuadKey(latitude,longitude);

            //Assert
            Assert.Equal("",result);
        }

    }
}
