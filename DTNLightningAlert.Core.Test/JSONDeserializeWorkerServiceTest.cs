using DTNLightningAlert.Core.Model;
using DTNLightningAlert.Core.WorkerService;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DTNLightningAlert.Core.Test
{
    public class JSONDeserializeWorkerServiceTest
    {
        private string lightningFilePath;

        [Fact]
        public void DeserializeJsonFileTestEmptyPath()
        {
            lightningFilePath = "";

            //Arrange
            var lightningData = new JSONDeserializeWorkerService<LightningModel>(lightningFilePath);

            //Act
            var actual = lightningData.DeserializeJsonFile();
            var expected = new List<LightningModel>();

            //Assert
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void DeserializeJsonFileTestNull()
        {
            lightningFilePath = null;

            //Arrange
            var lightningData = new JSONDeserializeWorkerService<LightningModel>(lightningFilePath);

            //Act
            var actual = lightningData.DeserializeJsonFile();
            var expected = new List<LightningModel>();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
