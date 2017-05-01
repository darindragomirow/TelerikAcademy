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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackageManager.Core;

namespace PackageManager.Tests.Commands.InstallCommandTests
{
    [TestFixture]
    class Properties
    {
        [Test]
        public void Operation_SetRightValue()
        {
            var installerMock=new Mock<IInstaller<IPackage>>();
            var packageMock = new Mock<IPackage>();
            installerMock.Setup(x => x.Operation).Returns(Enums.InstallerOperation.Install);
            var sut = new InstallCommand(installerMock.Object, packageMock.Object);

            var po = new PrivateObject(sut);
            var installer = (PackageInstaller)po.GetField("installer");

            NUnit.Framework.Assert.AreEqual(Enums.InstallerOperation.Install, installer.Operation);

        }
    }
}
