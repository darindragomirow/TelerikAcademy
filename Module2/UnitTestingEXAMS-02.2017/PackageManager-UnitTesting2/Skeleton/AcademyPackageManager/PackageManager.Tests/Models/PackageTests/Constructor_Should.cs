using Moq;
using NUnit.Framework;
using PackageManager.Models;
using PackageManager.Models.Contracts;
using System.Collections.Generic;

namespace PackageManager.Tests.Models.PackageTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void SetsTheAppropriatePassedValues_IfDependenciesIsSetCorrectlyForOptionalParameterDependencies()
        {
            var name = "Some package";
            var versionMock = new Mock<IVersion>();

            var package = new Package(name, versionMock.Object);

            Assert.IsInstanceOf<ICollection<IPackage>>(package.Dependencies);
            Assert.AreEqual(0, package.Dependencies.Count);
        }

        [Test]
        public void SetsTheAppropriatePassedValues_IfDependenciesIsSetCorrectlyForPassedParameterDependencies()
        {
            var name = "Some package";
            var versionMock = new Mock<IVersion>();

            var packageMock = new Mock<IPackage>();
            var listOfPackages = new HashSet<IPackage> { packageMock.Object };

            var package = new Package(name, versionMock.Object, listOfPackages);
            
            Assert.IsInstanceOf<ICollection<IPackage>>(package.Dependencies);
            Assert.AreEqual(1, package.Dependencies.Count);
        }
    }
}
