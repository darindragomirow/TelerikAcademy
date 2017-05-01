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
   public class PropertiesTests
    {
        [Test]
        public void ThrowArgumentException_WhenInvalidMajorIsPassed()
        {
            //Arrange & Act & Assert
            Assert.Throws<ArgumentException>(()=> new PackageVersion(-1, 2, 3, Enums.VersionType.alpha));   
        }
        [Test]
        public void SetMajor_WhenValidMajorIsPassed()
        {
            //Arrange
           var sut=new PackageVersion(1, 2, 3, Enums.VersionType.alpha);
            //Act & Assert
            Assert.AreEqual(1, sut.Major);

            
        }

        [Test]
        public void ThrowArgumentException_WhenInvalidMinorIsPassed()
        {
            //Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() => new PackageVersion(1, -2, 3, Enums.VersionType.alpha));
        }
        [Test]
        public void SetMinor_WhenValidMinorIsPassed()
        {
            //Arrange
            var sut = new PackageVersion(1, 2, 3, Enums.VersionType.alpha);
            //Act & Assert
            Assert.AreEqual(2, sut.Minor);
        }

        [Test]
        public void ThrowArgumentException_WhenInvalidPatchIsPassed()
        {
            //Arrange & Act & Assert
            Assert.Throws<ArgumentException>(() => new PackageVersion(-1, 2, -3, Enums.VersionType.alpha));
        }
        [Test]
        public void SetPatch_WhenValidPatchIsPassed()
        {
            //Arrange
            var sut = new PackageVersion(1, 2, 3, Enums.VersionType.alpha);
            //Act & Assert
            Assert.AreEqual(3, sut.Patch);
        }

        [Test]
        public void ThrowArgumentException_WhenInvalidVersionTypeIsPassed()
        {
            //Arrange & Act & Assert
            //Assert.Throws<ArgumentException>(() => new PackageVersion(1, 2, 3,"Invalid version Type");
        }
        [Test]
        public void NotThrowArgumentException_WhenValidVersionTypeIsPassed()
        {
            //Arrange
            var sut = new PackageVersion(1, 2, 3, Enums.VersionType.alpha);
            //Act & Assert
            Assert.AreEqual(VersionType.alpha, sut.VersionType);
        }
    }
}
