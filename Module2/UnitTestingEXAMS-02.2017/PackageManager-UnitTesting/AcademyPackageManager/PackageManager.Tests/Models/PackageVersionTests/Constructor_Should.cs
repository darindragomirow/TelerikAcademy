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
    public class Constructor_Should
    {
        [Test]
        public void SetMajorValue_WhenItIsPassedCorrectly()
        {
            //Arrange & Act
            var sut = new PackageVersion(5, 1, 3, VersionType.final);

            //Assert
            Assert.AreEqual(5, sut.Major);
        }

        [Test]
        public void SetMinorValue_WhenItIsPassedCorrectly()
        {
            //Arrange & Act
            var sut = new PackageVersion(5, 1, 3, VersionType.final);

            //Assert
            Assert.AreEqual(1, sut.Minor);
        }

        [Test]
        public void SetPatchValue_WhenItIsPassedCorrectly()
        {
            //Arrange & Act
            var sut = new PackageVersion(5, 1, 3, VersionType.final);

            //Assert
            Assert.AreEqual(3, sut.Patch);
        }

        [Test]
        public void SetVersionTypeValue_WhenItIsPassedCorrectly()
        {
            //Arrange & Act
            var sut = new PackageVersion(5, 1, 3, VersionType.final);

            //Assert
            Assert.AreEqual(VersionType.final, sut.VersionType);
        }
    }
}
