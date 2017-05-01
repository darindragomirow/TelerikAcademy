using Moq;
using NUnit.Framework;
using PackageManager.Commands;
using PackageManager.Core.Contracts;
using PackageManager.Models.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PackageManager.Tests.Commands.InstallCommandTests
{
    [TestFixture]
    class Constructor_Should
    {
        /*[Test]
        public void SetTheAppropiratePassedValues_WhenInvoked()
        {
            var installerMock = new Mock<IInstaller<IPackage>>();
            var packageMock = new Mock<IPackage>();
            var sut = new InstallCommand(installerMock.Object, packageMock.Object);
            installerMock.Setup(x => x.Operation).Returns(Enums.InstallerOperation.Install);
            
            var po = new PrivateObject(sut);

            var installer = po.GetField("installer");
            var package = po.GetField("package");
            

            NUnit.Framework.Assert.IsNotNull(installer);
        }
        */

    }
}
