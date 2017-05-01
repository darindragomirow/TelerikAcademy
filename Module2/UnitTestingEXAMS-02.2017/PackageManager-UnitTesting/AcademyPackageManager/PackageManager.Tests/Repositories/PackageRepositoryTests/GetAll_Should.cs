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
    public class GetAll_Should
    {
        [Test]
        public void ReturnEmptyCollection_WhenThereAreNoPackages()
        {
            //Arrange
            var versionMock = new Mock<IVersion>();
            var secondVersionMock = new Mock<IVersion>();
            var packageMock = new Mock<IPackage>();
            var secondPackageMock = new Mock<IPackage>();
            var loggerMock = new Mock<ILogger>();
            var repo = new PackageRepository(loggerMock.Object, new List<IPackage>());


            //Act
            var result = repo.GetAll();

            //Assert
            Assert.AreEqual(0, result.Count());
        }
    }
}
