using Moq;
using NUnit.Framework;
using PackageManager.Enums;
using PackageManager.Models;
using PackageManager.Models.Contracts;
using System;

namespace PackageManager.Tests.Models.PackageTests
{
    [TestFixture]
    public class Equals_Should
    {
        [Test]
        public void ThrowArgumentNullException_IfPassedValueIsNull()
        {
            var name = "PackageA";

            var versionMock = new Mock<IVersion>();

            var project = new Package(name, versionMock.Object);

            Assert.Throws<ArgumentNullException>(() => project.Equals(null));
        }

        [Test]
        public void NotThrowException_IfValidValueIsPassed()
        {
            var name = "PackageA";

            var versionMockForProject = new Mock<IVersion>();
            versionMockForProject.SetupGet(x => x.Major).Returns(1);
            versionMockForProject.SetupGet(x => x.Minor).Returns(2);
            versionMockForProject.SetupGet(x => x.Patch).Returns(3);
            versionMockForProject.SetupGet(x => x.VersionType).Returns(VersionType.alpha);

            var project = new Package(name, versionMockForProject.Object);

            var versionMockForPassedPackage = new Mock<IVersion>();
            versionMockForPassedPackage.SetupGet(x => x.Major).Returns(1);
            versionMockForPassedPackage.SetupGet(x => x.Minor).Returns(2);
            versionMockForPassedPackage.SetupGet(x => x.Patch).Returns(3);
            versionMockForPassedPackage.SetupGet(x => x.VersionType).Returns(VersionType.alpha);

            var packageMock = new Mock<IPackage>();
            packageMock.SetupGet(x => x.Name).Returns("PackageA");
            packageMock.SetupGet(x => x.Version).Returns(versionMockForPassedPackage.Object);

            Assert.DoesNotThrow(() => project.Equals(packageMock.Object));
        }

        [Test]
        public void ThrowArgumentException_IfPassedValueIsNotAnIPackageObject()
        {
            var name = "PackageA";

            var versionMockForProject = new Mock<IVersion>();
            versionMockForProject.SetupGet(x => x.Major).Returns(1);
            versionMockForProject.SetupGet(x => x.Minor).Returns(2);
            versionMockForProject.SetupGet(x => x.Patch).Returns(3);
            versionMockForProject.SetupGet(x => x.VersionType).Returns(VersionType.alpha);

            var project = new Package(name, versionMockForProject.Object);

            var versionMockForPassedPackage = new Mock<IVersion>();
            versionMockForPassedPackage.SetupGet(x => x.Major).Returns(1);
            versionMockForPassedPackage.SetupGet(x => x.Minor).Returns(2);
            versionMockForPassedPackage.SetupGet(x => x.Patch).Returns(3);
            versionMockForPassedPackage.SetupGet(x => x.VersionType).Returns(VersionType.alpha);

            var notIPackageObjectInstance = new Mock<IVersion>();

            Assert.Throws<ArgumentException>(() => project.Equals(notIPackageObjectInstance));
        }

        [Test]
        public void ReturnTrue_IfPassedPackageIsEqualToTheOtherPackage()
        {
            var name = "PackageA";

            var versionMockForProject = new Mock<IVersion>();
            versionMockForProject.SetupGet(x => x.Major).Returns(1);
            versionMockForProject.SetupGet(x => x.Minor).Returns(2);
            versionMockForProject.SetupGet(x => x.Patch).Returns(3);
            versionMockForProject.SetupGet(x => x.VersionType).Returns(VersionType.alpha);

            var project = new Package(name, versionMockForProject.Object);

            var versionMockForPassedPackage = new Mock<IVersion>();
            versionMockForPassedPackage.SetupGet(x => x.Major).Returns(1);
            versionMockForPassedPackage.SetupGet(x => x.Minor).Returns(2);
            versionMockForPassedPackage.SetupGet(x => x.Patch).Returns(3);
            versionMockForPassedPackage.SetupGet(x => x.VersionType).Returns(VersionType.alpha);

            var packageMock = new Mock<IPackage>();
            packageMock.SetupGet(x => x.Name).Returns("PackageA");
            packageMock.SetupGet(x => x.Version).Returns(versionMockForPassedPackage.Object);

            var arePackagesEqual = project.Equals(packageMock.Object);

            Assert.IsTrue(arePackagesEqual);
        }

        [Test]
        public void ReturnFalse_IfPassedPackageIsNotEqualToTheOtherPackage()
        {
            var name = "PackageA";

            var versionMockForProject = new Mock<IVersion>();
            versionMockForProject.SetupGet(x => x.Major).Returns(1);
            versionMockForProject.SetupGet(x => x.Minor).Returns(2);
            versionMockForProject.SetupGet(x => x.Patch).Returns(3);
            versionMockForProject.SetupGet(x => x.VersionType).Returns(VersionType.alpha);

            var project = new Package(name, versionMockForProject.Object);

            var versionMockForPassedPackage = new Mock<IVersion>();
            versionMockForPassedPackage.SetupGet(x => x.Major).Returns(2);
            versionMockForPassedPackage.SetupGet(x => x.Minor).Returns(1);
            versionMockForPassedPackage.SetupGet(x => x.Patch).Returns(3);
            versionMockForPassedPackage.SetupGet(x => x.VersionType).Returns(VersionType.rc);

            var packageMock = new Mock<IPackage>();
            packageMock.SetupGet(x => x.Name).Returns("Different package name");
            packageMock.SetupGet(x => x.Version).Returns(versionMockForPassedPackage.Object);

            var arePackagesEqual = project.Equals(packageMock.Object);

            Assert.IsFalse(arePackagesEqual);
        }
    }
}

