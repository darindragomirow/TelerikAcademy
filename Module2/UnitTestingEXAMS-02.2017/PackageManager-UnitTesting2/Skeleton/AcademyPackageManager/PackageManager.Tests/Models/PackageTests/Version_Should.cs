using Moq;
using NUnit.Framework;
using PackageManager.Models;
using PackageManager.Models.Contracts;

namespace PackageManager.Tests.Models.PackageTests
{
    [TestFixture]
    public class Version_Should
    {
        [Test]
        public void SetCorrectlyThePassedValue()
        {
            var name = "Some package";
            var versionMock = new Mock<IVersion>();

            var package = new Package(name, versionMock.Object);

            Assert.AreEqual(versionMock.Object, package.Version);
        }
    }
}
