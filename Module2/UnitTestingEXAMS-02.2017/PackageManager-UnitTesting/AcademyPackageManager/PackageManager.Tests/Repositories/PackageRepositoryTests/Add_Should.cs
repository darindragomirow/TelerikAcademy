using Moq;
using NUnit.Framework;
using PackageManager.Enums;
using PackageManager.Info.Contracts;
using PackageManager.Models.Contracts;
using PackageManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Repositories.PackageRepositoryTests
{
    [TestFixture]
    public class Add_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenPassedPackageIsNull()
        {
            //Arrange
            string expectedMessage = "The package cannot be null";
            var packageMock = new Mock<IPackage>();
            var loggerMock = new Mock<ILogger>();

            //Act
            var repo = new PackageRepository(loggerMock.Object, new List<IPackage>() { packageMock.Object });

            //Assert
            var exception = Assert.Catch<ArgumentNullException>(() => repo.Add(null));
            StringAssert.Contains(expectedMessage, exception.Message);
        }

        [Test]
        public void AddThePassedPackage_WhenItIsNotInTheCollection()
        {
            //Arrange
            var packageMock = new Mock<IPackage>();
            var loggerMock = new Mock<ILogger>();
            var repo = new PackageRepository(loggerMock.Object, new List<IPackage>());

            packageMock.SetupGet(x => x.Name).Returns("Ivan");

            //Act
            repo.Add(packageMock.Object);

            //Assert
            loggerMock.Verify(x => x.Log("Ivan: The package was added!"), Times.Once);
        }

        [Test]
        public void ReturnMessage_WhenPackageIsAlreadyInstalled()
        {
            //Arrange
            var packageMock = new Mock<IPackage>();
            var loggerMock = new Mock<ILogger>();
            var repo = new PackageRepository(loggerMock.Object, new List<IPackage>() { packageMock.Object });

            packageMock.SetupGet(x => x.Name).Returns("Ivan");

            //Act
            repo.Add(packageMock.Object);

            //Assert
            loggerMock.Verify(x => x.Log("Ivan: Package with the same version is already installed!"), Times.Once);
        }

        [Test]
        public void NotReturnMessage_WhenPackageIsInstalledWithLowerVersion()
        {
            //Arrange
            var versionMock = new Mock<IVersion>();
            var secondVersionMock = new Mock<IVersion>();
            var packageMock = new Mock<IPackage>();
            var secondPackageMock = new Mock<IPackage>();
            var loggerMock = new Mock<ILogger>();
            var repo = new PackageRepository(loggerMock.Object, new List<IPackage>() { packageMock.Object });

            versionMock.SetupGet(x => x.Major).Returns(1);
            versionMock.SetupGet(x => x.Minor).Returns(1);
            versionMock.SetupGet(x => x.Patch).Returns(1);
            versionMock.SetupGet(x => x.VersionType).Returns(VersionType.alpha);

            secondVersionMock.SetupGet(x => x.Major).Returns(2);
            secondVersionMock.SetupGet(x => x.Minor).Returns(2);
            secondVersionMock.SetupGet(x => x.Patch).Returns(2);
            secondVersionMock.SetupGet(x => x.VersionType).Returns(VersionType.beta);

            packageMock.SetupGet(x => x.Name).Returns("Ivan");
            packageMock.SetupGet(x => x.Version).Returns(versionMock.Object);

            secondPackageMock.SetupGet(x => x.Name).Returns("Ivan");
            secondPackageMock.SetupGet(x => x.Version).Returns(secondVersionMock.Object);
            //Act
            repo.Add(secondPackageMock.Object);

            //Assert
            loggerMock.Verify(x => x.Log(string.Empty), Times.Never());
        }

        [Test]
        public void ReturnAMessage_WhenPackageIsInstalledWithHigherVersion()
        {
            //Arrange
            var versionMock = new Mock<IVersion>();
            var secondVersionMock = new Mock<IVersion>();
            var packageMock = new Mock<IPackage>();
            var secondPackageMock = new Mock<IPackage>();
            var loggerMock = new Mock<ILogger>();
            var repo = new PackageRepository(loggerMock.Object, new List<IPackage>() { packageMock.Object });

            versionMock.SetupGet(x => x.Major).Returns(50);
            versionMock.SetupGet(x => x.Minor).Returns(2);
            versionMock.SetupGet(x => x.Patch).Returns(2);
            versionMock.SetupGet(x => x.VersionType).Returns(VersionType.beta);

            secondVersionMock.SetupGet(x => x.Major).Returns(1);
            secondVersionMock.SetupGet(x => x.Minor).Returns(1);
            secondVersionMock.SetupGet(x => x.Patch).Returns(1);
            secondVersionMock.SetupGet(x => x.VersionType).Returns(VersionType.alpha);

            packageMock.SetupGet(x => x.Name).Returns("Ivan");
            packageMock.SetupGet(x => x.Version).Returns(versionMock.Object);

            secondPackageMock.SetupGet(x => x.Name).Returns("Ivan");
            secondPackageMock.SetupGet(x => x.Version).Returns(secondVersionMock.Object);
            //Act
            repo.Add(secondPackageMock.Object);

            //Assert
            loggerMock.Verify(x => x.Log("Ivan: The package has higher version than you are trying to install!"), Times.Once());
        }
    }
}
