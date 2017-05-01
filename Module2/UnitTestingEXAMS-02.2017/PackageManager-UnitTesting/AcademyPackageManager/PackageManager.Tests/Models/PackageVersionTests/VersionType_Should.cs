using NUnit.Framework;
using PackageManager.Enums;
using PackageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.PackageVersionTests
{
    [TestFixture]
    public class VersionType_Should
    {
        [Test]
        public void ThrowArgumentException_WhenPassedValueIsInvalid()
        {
            //Arrange
            var versionType = (VersionType)5;

            //Act & Assert
            Assert.Throws<ArgumentException>(() => new PackageVersion(1, 2, 3, versionType));

            //TO DO: MAKE THIS SHIT WORK!
        }

        [Test]
        public void SetValue_WhenItIsPassedCorrectly()
        {
            //Arrange
            var sut = new PackageVersion(1, 2, 3, VersionType.final);


            //Assert
            Assert.AreEqual(VersionType.final, sut.VersionType);
        }
    }
}
