using Moq;
using NUnit.Framework;
using PackageManager.Commands;
using PackageManager.Core.Contracts;
using PackageManager.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.InstallCommandTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenThePassedInstallerValueIsNull()
        {
            //Arrange 
            var packageMock = new Mock<IPackage>();

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => new InstallCommand(null, packageMock.Object));
        }

        [Test]
        public void ThrowArgumentNullException_WhenThePassedPackageValueIsNull()
        {
            //Arrange 
            var installerMock = new Mock<IInstaller<IPackage>>();

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => new InstallCommand(installerMock.Object, null));
        }

        [Test]
        public void AssignInstallerValue_WhenItIsValid()
        {
            //Arrange 
            var installerMock = new Mock<IInstaller<IPackage>>();
            var packageMock = new Mock<IPackage>();

            //Act
            var command = new InstallCommand(installerMock.Object, packageMock.Object);

            //Assert
            Assert.AreEqual(installerMock.Object, command.Installer);
        }

        [Test]
        public void AssignPackageValue_WhenItIsValid()
        {
            //Arrange 
            var installerMock = new Mock<IInstaller<IPackage>>();
            var packageMock = new Mock<IPackage>();

            //Act
            var command = new InstallCommand(installerMock.Object, packageMock.Object);

            //Assert
            Assert.AreEqual(packageMock.Object, command.Package);
        }
    }
}
