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
    class CompareToTests
    {
        [Test]
        public void Other_ThrowArgumentNullException_WhenInvalidValueIsPassed()
        {
            //Arrange
            var sut = new Package("Valid Name", new PackageVersion(1, 2, 3, Enums.VersionType.alpha), null);

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => sut.CompareTo(null));
        }
        [Test]
        public void Other_ShouldNotThrowArgumentNullException_WhenValidValueIsPassed()
        {
            //Arrange
            var sut = new Package("Valid Name", new PackageVersion(1, 2, 3, Enums.VersionType.alpha), null);
            var other = new Package("Valid Name", new PackageVersion(1, 2, 3, Enums.VersionType.alpha), null);
            //Act & Assert
            Assert.DoesNotThrow(() => sut.CompareTo(other));
        }
        [Test]
        public void Other_ShouldNotThrowArgumentException_WhenPackageWithDifferentNameIsPassed()
        {
            //Arrange
            var sut = new Package("Valid Name", new PackageVersion(1, 2, 3, Enums.VersionType.alpha), null);
            var other = new Package("Invalid Name", new PackageVersion(1, 2, 3, Enums.VersionType.alpha), null);
            //Act & Assert
            Assert.Throws<ArgumentException>(() => sut.CompareTo(other));
        }

        [Test]
        public void Other_ShouldReturnCorrectResult_WhenPassedPackageWithHigherVersion()
        {
            //Arrange
            var sut = new Package("Valid Name", new PackageVersion(1, 2, 3, Enums.VersionType.alpha), null);
            var other = new Package("Valid Name", new PackageVersion(2, 2, 3, Enums.VersionType.alpha), null);
            //Act
            var result = sut.CompareTo(other);
            //Assert
            Assert.AreEqual(-1, result);            
        }
        [Test]
        public void Other_ShouldReturnCorrectResult_WhenPassedPackageWithLowerVersion()
        {
            //Arrange
            var sut = new Package("Valid Name", new PackageVersion(1, 2, 3, Enums.VersionType.alpha), null);
            var other = new Package("Valid Name", new PackageVersion(1, 1, 2, Enums.VersionType.alpha), null);
            //Act
            var result = sut.CompareTo(other);
            //Assert
            Assert.AreEqual(1, result);
        }
        [Test]
        public void Other_ShouldReturnCorrectResult_WhenPassedPackageIsWithSameVersion()
        {
            //Arrange
            var sut = new Package("Valid Name", new PackageVersion(1, 2, 3, Enums.VersionType.alpha), null);
            var other = new Package("Valid Name", new PackageVersion(1, 2, 3, Enums.VersionType.alpha), null);
            //Act
            var result = sut.CompareTo(other);
            //Assert
            Assert.AreEqual(0, result);
        }

    }
}
