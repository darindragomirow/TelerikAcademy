using Castle.Core.Logging;
using Moq;
using NUnit.Framework;
using PackageManager.Models;
using PackageManager.Models.Contracts;
using PackageManager.Repositories;
using PackageManager.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.ProjectTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void SetPackageRepository_WhenItsValueIsNotPassed()
        {
            //Arrange & Act
            var sut = new Project("ivan", "ei tam");

            //Assert
            Assert.IsInstanceOf<PackageRepository>(sut.PackageRepository);
        }

        [Test]
        public void SetPackageRepository_WhenItsValueIsPassed()
        {
            //Arrange & Act
            var packageMock = new Mock<IPackage>();
            var loggerMock = new Mock<Info.Contracts.ILogger>();
            var repo = new PackageRepository(loggerMock.Object, new List<IPackage> { packageMock.Object });

            var sut = new Project("ivan", "ei tam", repo);

            //Assert
            Assert.AreEqual(repo, sut.PackageRepository);
        }
    }
}
