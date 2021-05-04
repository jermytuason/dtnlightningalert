using DTNLightningAlert.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DTNLightningAlert.Core.Test
{
    public class FileValidationTest
    {
        string path;

        [Fact]
        public void FileCheckerTestEmptyString()
        {
            path = null;

            //Arrange
            var expected = "";

            //Act
            var actual = FileValidation.FileChecker(path);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
