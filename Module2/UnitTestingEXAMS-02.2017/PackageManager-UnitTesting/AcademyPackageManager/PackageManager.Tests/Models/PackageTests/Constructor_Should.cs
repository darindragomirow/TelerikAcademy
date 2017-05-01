
using Moq;
using NUnit.Framework;
using PackageManager.Models;
using PackageManager.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.PackageTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void SetDependencies_WhenItsValueIsNotPassed()
        {
            //Arrange
            string name = "ivan";
            var versionMock = new Mock<IVersion>();

            //Act
            var package = new Package(name, versionMock.Object);

            //Assert
            Assert.IsInstanceOf<ICollection<IPackage>>(package.Dependencies);
        }

        [Test]
        public void SetDependencies_WhenItsValueIPassedCorrectly()
        {
            //Arrange
            string name = "ivan";
            var versionMock = new Mock<IVersion>();
            var packageMock = new Mock<IPackage>();
            var dependencies = new List<IPackage> { packageMock.Object };

            //Act
            var package = new Package(name, versionMock.Object, dependencies);

            //Assert
            Assert.AreEqual(dependencies, package.Dependencies);
        }
    }
}
