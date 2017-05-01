using Moq;
using NUnit.Framework;
using PackageManager.Core.Contracts;
using PackageManager.Enums;
using PackageManager.Models.Contracts;
using PackageManager.Tests.Commands.InstallCommandTests.Mocks;

namespace PackageManager.Tests.Commands.InstallCommandTests
{
    [TestFixture]
    public class Operation_Should
    {
        [Test]
        public void SetTheOperationOfTheInstaller_WhenValidValueIsPassed()
        {
            var installerMock = new Mock<IInstaller<IPackage>>();
            installerMock.SetupGet(x => x.Operation).Returns(InstallerOperation.Install);

            var packageMock = new Mock<IPackage>();

            var installCommandMokedObj = new InstallCommandMocked(installerMock.Object, packageMock.Object);

            Assert.AreEqual(installerMock.Object.Operation, installCommandMokedObj.Installer.Operation);
        }
    }
}
