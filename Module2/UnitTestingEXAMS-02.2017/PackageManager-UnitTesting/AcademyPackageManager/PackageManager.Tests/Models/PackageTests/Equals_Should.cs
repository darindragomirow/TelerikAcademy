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
    public class Equals_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenThePassedValueIsNull()
        {
            //Arrange
            string name = "Ivan";
            var versionMock = new Mock<IVersion>();

            versionMock.SetupGet(x => x.Major).Returns(1);
            versionMock.SetupGet(x => x.Minor).Returns(2);
            versionMock.SetupGet(x => x.Patch).Returns(3);
            versionMock.SetupGet(x => x.VersionType).Returns(VersionType.final);

            var package = new Package(name, versionMock.Object);

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => package.Equals(null));
        }

        [Test]
        public void ThrowArgumentNullException_WhenThePassedObjectIsNotIPackage()
        {
            //Arrange
            string name = "Ivan";
            var versionMock = new Mock<IVersion>();

            versionMock.SetupGet(x => x.Major).Returns(1);
            versionMock.SetupGet(x => x.Minor).Returns(2);
            versionMock.SetupGet(x => x.Patch).Returns(3);
            versionMock.SetupGet(x => x.VersionType).Returns(VersionType.final);

            var package = new Package(name, versionMock.Object);

            //Act & Assert
            Assert.Throws<ArgumentException>(() => package.Equals(5));
        }

        [Test]
        public void ReturnTrue_WhenThePackagesAreEqual()
        {
            //Arrange
            string name = "Ivan";
            var versionMock = new Mock<IVersion>();
            var otherVersionMock = new Mock<IVersion>();
            var packageMock = new Mock<IPackage>();

            versionMock.SetupGet(x => x.Major).Returns(1);
            versionMock.SetupGet(x => x.Minor).Returns(2);
            versionMock.SetupGet(x => x.Patch).Returns(3);
            versionMock.SetupGet(x => x.VersionType).Returns(VersionType.final);

            otherVersionMock.SetupGet(x => x.Major).Returns(1);
            otherVersionMock.SetupGet(x => x.Minor).Returns(2);
            otherVersionMock.SetupGet(x => x.Patch).Returns(3);
            otherVersionMock.SetupGet(x => x.VersionType).Returns(VersionType.final);

            packageMock.SetupGet(x => x.Name).Returns("Ivan");
            packageMock.SetupGet(x => x.Version).Returns(otherVersionMock.Object);

            var package = new Package(name, versionMock.Object);

            //Act & Assert
            Assert.IsTrue(package.Equals(packageMock.Object));
        }

        [Test]
        public void ReturnFalse_WhenThePackagesAreEqual()
        {
            //Arrange
            string name = "Ivan";
            var versionMock = new Mock<IVersion>();
            var otherVersionMock = new Mock<IVersion>();
            var packageMock = new Mock<IPackage>();

            versionMock.SetupGet(x => x.Major).Returns(1);
            versionMock.SetupGet(x => x.Minor).Returns(2);
            versionMock.SetupGet(x => x.Patch).Returns(3);
            versionMock.SetupGet(x => x.VersionType).Returns(VersionType.final);

            otherVersionMock.SetupGet(x => x.Major).Returns(1);
            otherVersionMock.SetupGet(x => x.Minor).Returns(3);
            otherVersionMock.SetupGet(x => x.Patch).Returns(3);
            otherVersionMock.SetupGet(x => x.VersionType).Returns(VersionType.final);

            packageMock.SetupGet(x => x.Name).Returns("Ivan");
            packageMock.SetupGet(x => x.Version).Returns(otherVersionMock.Object);

            var package = new Package(name, versionMock.Object);

            //Act & Assert
            Assert.IsFalse(package.Equals(packageMock.Object));
        }
    }
}
