
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
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
    class DeleteTests
    {
        [Test]
        public void DeletePackage_WhenPackageIsInvalid()//Also checking that package cannot be found
        {
            var loggerMock = new Mock<ILogger>();
            var sut = new PackageRepository(loggerMock.Object, null);

            //Act & Assert
            var ex=NUnit.Framework.Assert.Throws<ArgumentNullException>(() => sut.Delete(null));
            NUnit.Framework.StringAssert.Contains("Package cannot be null", ex.Message);
        }
        [Test]
        public void DeletePackage_WhenPackageIsValid() //Also checking that return the removed object
        {
            //Arrange
            var loggerMock = new Mock<ILogger>();
            var sut = new PackageRepository(loggerMock.Object, null);
            var version = new PackageVersion(1, 2, 3, Enums.VersionType.alpha);
            var package = new Package("pack1", version);
            var po = new PrivateObject(sut);
            var packages = (ICollection<IPackage>)po.GetField("packages");

            //Act
            sut.Add(package);
            var result = sut.Delete(package);

            //Assert
            NUnit.Framework.Assert.AreSame(package, result);
        }
        [Test]
        public void PackageFound_ButIsADependency()
        {
            var loggerMock = new Mock<ILogger>();
            var sut = new PackageRepository(loggerMock.Object, null);
            var version = new PackageVersion(1, 2, 3, Enums.VersionType.alpha);
            var dependencies = new HashSet<IPackage>();
            var depPackage = new Package("depPackage", version);
            dependencies.Add(depPackage);
            var package = new Package("pack1", version,dependencies);
            var po = new PrivateObject(sut);
            var packages = (ICollection<IPackage>)po.GetField("packages");
           // loggerMock.Setup(x => x.Log("Please remove the dependencies first!"));

            var result = sut.Delete(package);

            loggerMock.Verify(x => x.Log("Please remove the dependencies first!")); //Don't know what I'm doing...

        }

    }
}
