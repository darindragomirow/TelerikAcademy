
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using PackageManager.Enums;
using PackageManager.Info.Contracts;
using PackageManager.Models;
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
    class AddTests
    {
        [Test]
        public void AddPackage_WhenPackageIsInvalid()
        {
            //Arrange
            var loggerMock = new Mock<ILogger>();
            var sut = new PackageRepository(loggerMock.Object, null);

            //Act & Assert
            NUnit.Framework.Assert.Throws<ArgumentNullException>(() => sut.Add(null));
        }
        [Test]
        public void AddPackage_WhenPackageIsValid()
        {
            //Arrange
            var loggerMock = new Mock<ILogger>();
            var sut = new PackageRepository(loggerMock.Object, null);
            var package = new Mock<IPackage>();
            var po = new PrivateObject(sut);
            var packages = (ICollection < IPackage >)po.GetField("packages");

            //Act
            sut.Add(package.Object);

            //Assert
            NUnit.Framework.Assert.AreEqual(1, packages.Count());
        }
        [Test]
        public void AddingPackage_WhenItDoesNotExist()
        {
            var loggerMock = new Mock<ILogger>();
            var sut = new PackageRepository(loggerMock.Object, null);
            var version = new PackageVersion(1, 2, 3, Enums.VersionType.alpha);
            var package = new Package("pack1", version); 
            var po = new PrivateObject(sut);
            var packages = (ICollection<IPackage>)po.GetField("packages");

            //Act & Assert
            NUnit.Framework.Assert.DoesNotThrow(()=> sut.Add(package));
        }
        [Test]
        public void AddingPackage_WhenItAlreadyExist()
        {
            var loggerMock = new Mock<ILogger>();
            var sut = new PackageRepository(loggerMock.Object, null);
            var version = new PackageVersion(1, 2, 3, Enums.VersionType.alpha);
            var package = new Package("pack1", version);
            var po = new PrivateObject(sut);
            var packages = (ICollection<IPackage>)po.GetField("packages");

            sut.Add(new Package("test", new PackageVersion(1, 1, 1, VersionType.alpha)));

            //Assert
            
        }
    }
}
