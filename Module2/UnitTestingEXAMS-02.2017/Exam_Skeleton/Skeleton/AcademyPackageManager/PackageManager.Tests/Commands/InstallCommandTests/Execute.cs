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

namespace PackageManager.Tests.Commands.InstallCommandTests
{
    [TestFixture]
    class Execute
    {
        [Test]
        public void InstallerCommand_ShouldCallPerformOperationFromInstaller()
        {
            var installerMock = new Mock<IInstaller<IPackage>>();
            var packageMock = new Mock<IPackage>();
            var sut = new InstallCommand(installerMock.Object, packageMock.Object);
            installerMock.Setup(x => x.PerformOperation(It.IsAny<IPackage>()));

            sut.Execute();

            installerMock.Verify(x => x.PerformOperation(packageMock.Object));

            
        }
    }
}
