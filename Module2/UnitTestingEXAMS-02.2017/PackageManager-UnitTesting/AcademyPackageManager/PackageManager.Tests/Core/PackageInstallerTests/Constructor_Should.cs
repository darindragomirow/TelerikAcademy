using Moq;
using NUnit.Framework;
using PackageManager.Core;
using PackageManager.Core.Contracts;
using PackageManager.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Core.PackageInstallerTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void RestorePackages_WhenObjectIsConstructed()
        {
            //Arrange
            var downloaderMock = new Mock<IDownloader>();
            var projectMock = new Mock<IProject>();

            downloaderMock.Setup(x => x.Remove(It.IsAny<string>()));
            downloaderMock.Setup(x => x.Download(It.IsAny<string>()));
            projectMock.Setup(x => x.Location).Returns("location");

            var packageMock = new Mock<IPackage>();
            packageMock.Setup(x => x.Name).Returns("name");

            projectMock.Setup(x => x.PackageRepository.GetAll()).Returns(new List<IPackage>() { packageMock.Object });

            var packageDependencyOne = new Mock<IPackage>();
            packageDependencyOne.Setup(x => x.Name).Returns("namedepOne");
            packageDependencyOne.Setup(x => x.Dependencies).Returns(new List<IPackage>());

            packageMock.Setup(x => x.Dependencies.Count).Returns(1);
            packageMock.Setup(x => x.Dependencies).Returns(new List<IPackage>() { packageDependencyOne.Object });

            //Act
            var sut = new PackageInstaller(downloaderMock.Object, projectMock.Object);

            //Assert
            projectMock.Verify(x => x.PackageRepository.Add(It.IsAny<IPackage>()), Times.Exactly(2));
        }
    }
}
