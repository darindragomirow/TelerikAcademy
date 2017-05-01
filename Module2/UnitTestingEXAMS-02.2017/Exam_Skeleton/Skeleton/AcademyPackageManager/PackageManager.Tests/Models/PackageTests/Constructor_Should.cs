using Moq;
using NUnit.Framework;
using PackageManager.Models;
using PackageManager.Models.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.PackageTests
{
    [TestFixture]
    class Constructor_Should
    {
       /* [Test]
        public void SetCorrectlyDependencies_WhenOptionalDependenciesArePassed()
        {
            //Arrange
            var depMock = new Mock<ICollection>();
            var version = new PackageVersion(1, 2, 3, Enums.VersionType.alpha);

            var sut = new Package("Valid Name",version,depMock.Object);

            //Act & Assert
            Assert.AreEqual(sut.Dependencies,dependencies);

        }
        */

        [Test]
        public void SetCorrectlyDependencies_WhenNoDependenciesArePassed()
        {
            //Arrange
            var version = new PackageVersion(1, 2, 3, Enums.VersionType.alpha);

            var sut = new Package("Valid Name", version);

            //Act & Assert
            Assert.IsNotNull(sut.Dependencies);
        }

    }
}
