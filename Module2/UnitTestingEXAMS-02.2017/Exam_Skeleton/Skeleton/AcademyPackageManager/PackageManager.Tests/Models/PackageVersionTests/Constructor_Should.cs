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
        public void SetsAppropriatePassedValues_WhenInvoked()
        {
            //Arrange & Act
            var sut = new PackageVersion(3,4,4,VersionType.alpha);

            //Assert
            Assert.AreEqual(3, sut.Major);
            Assert.AreEqual(4, sut.Minor);
            Assert.AreEqual(4, sut.Patch);
            Assert.AreEqual(VersionType.alpha, sut.VersionType);

        }
    }
}
