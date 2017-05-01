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
    class EqualsTests
    {
        [Test]
        public void Other_ThrowArgumentNullException_WhenInvalidValueIsPassed()
        {
            //Arrange
            var sut = new Package("Valid Name", new PackageVersion(1, 2, 3, Enums.VersionType.alpha), null);

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => sut.Equals(null));
        }
        [Test]
        public void Other_ShouldNotThrowArgumentNullException_WhenValidValueIsPassed()
        {
            //Arrange
            var sut = new Package("Valid Name", new PackageVersion(1, 2, 3, Enums.VersionType.alpha), null);
            var other = new Package("Valid Name", new PackageVersion(1, 2, 3, Enums.VersionType.alpha), null);
            //Act & Assert
            Assert.DoesNotThrow(() => sut.Equals(other));
        }

        [Test]
        public void Other_ShouldBeIPackage()
        {
            var sut = new Package("Valid Name", new PackageVersion(1, 2, 3, Enums.VersionType.alpha), null);
            var otherMock = new Mock<IPackage>();

            Assert.IsInstanceOf<IPackage>(otherMock.Object);
            //OR
            var otherMock2 = new Mock<IProject>();
            Assert.Throws<ArgumentException>(() => sut.Equals(otherMock2.Object));  
        }
        [Test]
        public void ReturnCorrectValue_WhenPackagesAreEqual()
        {
            //Arrange
            var sut = new Package("Valid Name", new PackageVersion(1, 2, 3, Enums.VersionType.alpha), null);
            var other = new Package("Valid Name", new PackageVersion(1, 2, 3, Enums.VersionType.alpha), null);
            //Act
            var result = sut.Equals(other);
            //Assert
            Assert.AreEqual(true, result);
        }
        [Test]
        public void ReturnCorrectValue_WhenPackagesAreNotEqual()
        {
            //Arrange
            var sut = new Package("Valid Name", new PackageVersion(1, 2, 3, Enums.VersionType.alpha), null);
            var other = new Package("InValid Name", new PackageVersion(3, 4, 3, Enums.VersionType.alpha), null);
            //Act
            var result = sut.Equals(other);
            //Assert
            Assert.AreEqual(false, result);
        }


    }
}
