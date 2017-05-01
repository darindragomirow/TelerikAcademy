using Moq;
using NUnit.Framework;
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
    public class Version_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenThePassedValueIsInvalid()
        {

            //Arrange
            string name = "ivan";

            //versionMock.SetupGet(x => x.Major).Returns(1);
            //versionMock.SetupGet(x => x.Minor).Returns(2);
            //versionMock.SetupGet(x => x.Patch).Returns(3);
            //versionMock.SetupGet(x => x.VersionType).Returns(VersionType.final);

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => new Package(name, null));
        }

        [Test]
        public void AssignVersion_WhenThePassedValueIsValid()
        {

            //Arrange
            string name = "ivan";
            var versionMock = new Mock<IVersion>();

            //versionMock.SetupGet(x => x.Major).Returns(1);
            //versionMock.SetupGet(x => x.Minor).Returns(2);
            //versionMock.SetupGet(x => x.Patch).Returns(3);
            //versionMock.SetupGet(x => x.VersionType).Returns(VersionType.final);

            //Act
            var package = new Package(name, versionMock.Object);

            //Assert
            Assert.AreEqual(versionMock.Object, package.Version);
        }
    }
}
