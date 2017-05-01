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
    public class CompareTo_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenOtherIsNull()
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
            Assert.Throws<ArgumentNullException>(() => package.CompareTo(null));
        }

        [Test]
        public void ThrowArgumentException_WhenTheNamesOfTheComparedPackagesAreDifferent()
        {
            //Arrange
            string name = "Ivan";
            var versionMock = new Mock<IVersion>();
            var packageMock = new Mock<IPackage>();

            versionMock.SetupGet(x => x.Major).Returns(1);
            versionMock.SetupGet(x => x.Minor).Returns(2);
            versionMock.SetupGet(x => x.Patch).Returns(3);
            versionMock.SetupGet(x => x.VersionType).Returns(VersionType.final);

            packageMock.SetupGet(x => x.Name).Returns("Eazy-E");

            var package = new Package(name, versionMock.Object);

            //Act & Assert
            Assert.Throws<ArgumentException>(() => package.CompareTo(packageMock.Object));
        }

        [Test]
        public void NotThrow_WhenOtherIsValid()
        {
            //Arrange
            string name = "Ivan";
            var versionMock = new Mock<IVersion>();
            var packageMock = new Mock<IPackage>();

            versionMock.SetupGet(x => x.Major).Returns(1);
            versionMock.SetupGet(x => x.Minor).Returns(2);
            versionMock.SetupGet(x => x.Patch).Returns(3);
            versionMock.SetupGet(x => x.VersionType).Returns(VersionType.final);

            packageMock.SetupGet(x => x.Name).Returns("Ivan");
            packageMock.SetupGet(x => x.Version).Returns(versionMock.Object);

            var package = new Package(name, versionMock.Object);

            //Act & Assert
            Assert.DoesNotThrow(() => package.CompareTo(packageMock.Object));
        }

        [Test]
        public void ReturnOne_WhenThisVersionIsHigherThanTheOther()
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
            otherVersionMock.SetupGet(x => x.Minor).Returns(1);
            otherVersionMock.SetupGet(x => x.Patch).Returns(3);
            otherVersionMock.SetupGet(x => x.VersionType).Returns(VersionType.final);

            packageMock.SetupGet(x => x.Name).Returns("Ivan");
            packageMock.SetupGet(x => x.Version).Returns(otherVersionMock.Object);

            var package = new Package(name, versionMock.Object);

            //Act & Assert
            Assert.AreEqual(1, package.CompareTo(packageMock.Object));
        }

        [Test]
        public void ReturnMinusOne_WhenThisVersionIsLowerThanThe()
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
            otherVersionMock.SetupGet(x => x.Minor).Returns(4);
            otherVersionMock.SetupGet(x => x.Patch).Returns(3);
            otherVersionMock.SetupGet(x => x.VersionType).Returns(VersionType.final);

            packageMock.SetupGet(x => x.Name).Returns("Ivan");
            packageMock.SetupGet(x => x.Version).Returns(otherVersionMock.Object);

            var package = new Package(name, versionMock.Object);

            //Act & Assert
            Assert.AreEqual(-1, package.CompareTo(packageMock.Object));
        }

        [Test]
        public void ReturnZero_WhenTheVersionsAreTheSame()
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
            Assert.AreEqual(0, package.CompareTo(packageMock.Object));
        }
    }
}
