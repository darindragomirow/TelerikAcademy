using Moq;
using NUnit.Framework;
using PackageManager.Enums;
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
    public class Name_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenThePassedValueIsInvalid()
        {

            //Arrange
            string name = null;
            var versionMock = new Mock<IVersion>();

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => new Package(name, versionMock.Object));
        }

        [Test]
        public void AssignName_WhenThePassedValueIsValid()
        {

            //Arrange
            string name = "ivan";
            var versionMock = new Mock<IVersion>();

            //Act
            var package = new Package(name, versionMock.Object);

            //Assert
            Assert.AreEqual(name, package.Name);
        }
    }
}
