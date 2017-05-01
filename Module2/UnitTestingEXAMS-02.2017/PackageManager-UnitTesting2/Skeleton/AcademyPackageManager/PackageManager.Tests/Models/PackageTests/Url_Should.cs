using Moq;
using NUnit.Framework;
using PackageManager.Enums;
using PackageManager.Models;
using PackageManager.Models.Contracts;

namespace PackageManager.Tests.Models.PackageTests
{
    [TestFixture]
    public class Url_Should
    {
        [Test]
        public void SetCorrectlyThePassedValue()
        {
            var name = "Some package";

            var versionMock = new Mock<IVersion>();
            versionMock.SetupGet(x => x.Major).Returns(1);
            versionMock.SetupGet(x => x.Minor).Returns(2);
            versionMock.SetupGet(x => x.Patch).Returns(3);
            versionMock.SetupGet(x => x.VersionType).Returns(VersionType.rc);
            
            var package = new Package(name, versionMock.Object);

            var expectedUrlString = string.Format("{0}.{1}.{2}-{3}",
                versionMock.Object.Major,
                versionMock.Object.Minor,
                versionMock.Object.Patch,
                versionMock.Object.VersionType);

            Assert.AreEqual(expectedUrlString, package.Url);
        }
    }
}
