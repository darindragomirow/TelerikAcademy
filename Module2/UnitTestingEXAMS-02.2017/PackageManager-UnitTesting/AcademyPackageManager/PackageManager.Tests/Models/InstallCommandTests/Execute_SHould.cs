using Moq;
using NUnit.Framework;
using PackageManager.Commands;
using PackageManager.Commands.Contracts;
using PackageManager.Core.Contracts;
using PackageManager.Enums;
using PackageManager.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.InstallCommandTests
{
    [TestFixture]
    public class Execute_Should
    {
        [Test]
        //[Ignore("verify not working")]
        public void ShoudPerformOperation_WhenItIsCalled()
        {
            //Arrange 
            var installerMock = new Mock<IInstaller<IPackage>>();
            var packageMock = new Mock<IPackage>();
            var commandMock = new Mock<ICommand>();
            var command = new InstallCommand(installerMock.Object, packageMock.Object);

            //Act
            command.Execute();

            //Assert
            installerMock.Verify(x => x.PerformOperation(It.IsAny<IPackage>()), Times.Once);

        }
    }
}
