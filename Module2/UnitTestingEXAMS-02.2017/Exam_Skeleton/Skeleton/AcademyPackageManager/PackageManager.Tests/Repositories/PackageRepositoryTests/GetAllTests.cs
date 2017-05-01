using Moq;
using NUnit.Framework;
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
   public class GetAllTests
    {
        [Test]
        public void ShouldReturnEmptyCollection_WhenInvoked()
        {
            //Arrange
            var loggerMock = new Mock<ILogger>();
            var sut = new PackageRepository(loggerMock.Object, null);

            //Act
            var result = sut.GetAll();

            //Assert
            Assert.AreEqual(1, result.Count());


        }
        [Test]
        public void ShouldReturnCollection_WhenInvoked()
        {
            //Arrange
            var loggerMock = new Mock<ILogger>();
            var packages = new HashSet<IPackage>();
            var package = new Mock<IPackage>();
            packages.Add(package.Object);
            var sut = new PackageRepository(loggerMock.Object, packages);

            //Act
            var result = sut.GetAll();

            //Assert
            Assert.AreEqual(2, result.Count());


        }
    }
}
