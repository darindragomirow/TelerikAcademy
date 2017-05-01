using Moq;
using NUnit.Framework;
using PackageManager.Enums;
using PackageManager.Models;
using PackageManager.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.PackageTests
{
    [TestFixture]
    public class Url_Should
    {
        [Test]
        public void CreateAStringWithTheVersionProperties_WhenTheyAreValid()
        {

            //Arrange
            string name = "ivan";
            var versionMock = new Mock<IVersion>();

            versionMock.SetupGet(x => x.Major).Returns(1);
            versionMock.SetupGet(x => x.Minor).Returns(2);
            versionMock.SetupGet(x => x.Patch).Returns(3);
            versionMock.SetupGet(x => x.VersionType).Returns(VersionType.final);

            string expectedUrl = string.Format($"{versionMock.Object.Major}.{versionMock.Object.Minor}.{versionMock.Object.Patch}-{versionMock.Object.VersionType}");
            //Act
            var package = new Package(name, versionMock.Object);

            //Assert
            Assert.AreEqual(expectedUrl, package.Url);
        }
    }
}
