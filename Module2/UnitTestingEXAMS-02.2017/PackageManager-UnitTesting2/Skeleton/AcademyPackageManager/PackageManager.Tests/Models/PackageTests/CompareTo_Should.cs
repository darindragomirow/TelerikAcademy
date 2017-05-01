using Moq;
using NUnit.Framework;
using PackageManager.Enums;
using PackageManager.Models;
using PackageManager.Models.Contracts;
using System;

namespace PackageManager.Tests.Models.PackageTests
{
    [TestFixture]
    public class CompareTo_Should
    {
        [Test]
        public void ThrowArgumentNullException_IfPassedValueIsNull()
        {
            var name = "PackageA";

            var versionMock = new Mock<IVersion>();

            var project = new Package(name, versionMock.Object);

            Assert.Throws<ArgumentNullException>(() => project.CompareTo(null));
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

            Assert.DoesNotThrow(() => project.CompareTo(packageMock.Object));    
        }

        [Test]
        public void ThrowArgumentException_IfPassedPackageIsNotWithTheSameName()
        {
            var name = "PackageA";

            var versionMockForProject = new Mock<IVersion>();
            versionMockForProject.SetupGet(x => x.Major).Returns(1);
            versionMockForProject.SetupGet(x => x.Minor).Returns(2);
            versionMockForProject.SetupGet(x => x.Patch).Returns(3);
            versionMockForProject.SetupGet(x => x.VersionType).Returns(VersionType.rc);

            var project = new Package(name, versionMockForProject.Object);

            var versionMockForPackage = new Mock<IVersion>();

            var packageMock = new Mock<IPackage>();
            packageMock.SetupGet(x => x.Name).Returns("Different package");
            packageMock.SetupGet(x => x.Version).Returns(versionMockForPackage.Object);

            Assert.Throws<ArgumentException>(() => project.CompareTo(packageMock.Object));
        }

        [Test]
        public void ReturnMinusOne_IfThePassedPackageIsWithHigherVersion()
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
            versionMockForPassedPackage.SetupGet(x => x.VersionType).Returns(VersionType.rc);

            var packageMock = new Mock<IPackage>();
            packageMock.SetupGet(x => x.Name).Returns("PackageA");
            packageMock.SetupGet(x => x.Version).Returns(versionMockForPassedPackage.Object);

            var resultFromCompareTo = project.CompareTo(packageMock.Object);

            Assert.AreEqual(-1, resultFromCompareTo);
        }

        [Test]
        public void ReturnOne_IfThePassedPackageIsWithLowerVersion()
        {
            var name = "PackageA";

            var versionMockForProject = new Mock<IVersion>();
            versionMockForProject.SetupGet(x => x.Major).Returns(1);
            versionMockForProject.SetupGet(x => x.Minor).Returns(2);
            versionMockForProject.SetupGet(x => x.Patch).Returns(3);
            versionMockForProject.SetupGet(x => x.VersionType).Returns(VersionType.final);

            var project = new Package(name, versionMockForProject.Object);

            var versionMockForPassedPackage = new Mock<IVersion>();
            versionMockForPassedPackage.SetupGet(x => x.Major).Returns(1);
            versionMockForPassedPackage.SetupGet(x => x.Minor).Returns(2);
            versionMockForPassedPackage.SetupGet(x => x.Patch).Returns(3);
            versionMockForPassedPackage.SetupGet(x => x.VersionType).Returns(VersionType.beta);

            var packageMock = new Mock<IPackage>();
            packageMock.SetupGet(x => x.Name).Returns("PackageA");
            packageMock.SetupGet(x => x.Version).Returns(versionMockForPassedPackage.Object);

            var resultFromCompareTo = project.CompareTo(packageMock.Object);

            Assert.AreEqual(1, resultFromCompareTo);
        }

        [Test]
        public void ReturnZero_IfThePassedPackageIsWithLowerVersion()
        {
            var name = "PackageA";

            var versionMockForProject = new Mock<IVersion>();
            versionMockForProject.SetupGet(x => x.Major).Returns(1);
            versionMockForProject.SetupGet(x => x.Minor).Returns(2);
            versionMockForProject.SetupGet(x => x.Patch).Returns(3);
            versionMockForProject.SetupGet(x => x.VersionType).Returns(VersionType.rc);

            var project = new Package(name, versionMockForProject.Object);

            var versionMockForPassedPackage = new Mock<IVersion>();
            versionMockForPassedPackage.SetupGet(x => x.Major).Returns(1);
            versionMockForPassedPackage.SetupGet(x => x.Minor).Returns(2);
            versionMockForPassedPackage.SetupGet(x => x.Patch).Returns(3);
            versionMockForPassedPackage.SetupGet(x => x.VersionType).Returns(VersionType.rc);

            var packageMock = new Mock<IPackage>();
            packageMock.SetupGet(x => x.Name).Returns("PackageA");
            packageMock.SetupGet(x => x.Version).Returns(versionMockForPassedPackage.Object);

            var resultFromCompareTo = project.CompareTo(packageMock.Object);

            Assert.AreEqual(0, resultFromCompareTo);
        }
    }
}
