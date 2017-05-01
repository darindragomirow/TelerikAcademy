using Moq;
using NUnit.Framework;
using PackageManager.Core.Contracts;
using PackageManager.Models.Contracts;
using PackageManager.Tests.Commands.InstallCommandTests.Mocks;

namespace PackageManager.Tests.Commands.InstallCommandTests
{
    [TestFixture]
    public class Execute_Should
    {
        [Test]
        public void CheckIfPerformOperationIsCalled()
        {
            var installerMock = new Mock<IInstaller<IPackage>>();

            var packageMock = new Mock<IPackage>();

            var installCommandMockObj = new InstallCommandMocked(installerMock.Object, packageMock.Object);

            installCommandMockObj.Execute();

            installerMock.Verify(x => x.PerformOperation(It.IsAny<IPackage>()), Times.Once);
        }
    }
}