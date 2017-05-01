using Moq;
using NUnit.Framework;
using PackageManager.Commands;
using PackageManager.Core.Contracts;
using PackageManager.Enums;
using PackageManager.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.InstallCommandTests
{
    [TestFixture]
    public class InstallerOperation_Should
    {
        [Test]
        public void AssignPackageValue_WhenItIsValid()
        {
            //Arrange 
            var installerMock = new Mock<IInstaller<IPackage>>();
            var packageMock = new Mock<IPackage>();

            //Act
            var command = new InstallCommand(installerMock.Object, packageMock.Object);

            //Assert
            Assert.AreEqual(InstallerOperation.Install, command.Installer.Operation);
        }
    }
}
