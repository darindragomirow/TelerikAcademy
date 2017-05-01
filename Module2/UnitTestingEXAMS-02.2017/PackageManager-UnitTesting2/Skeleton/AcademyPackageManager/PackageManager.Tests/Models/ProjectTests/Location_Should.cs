using NUnit.Framework;
using PackageManager.Models;

namespace PackageManager.Tests.Models.ProjectTests
{
    [TestFixture]
    public class Location_Should
    {
        [Test]
        public void SetCorrectly_WhenValidValueIsPassed()
        {
            var name = "JSPackage";
            var location = "ServerA";

            var project = new Project(name, location);

            Assert.AreEqual(location, project.Location);
        }
    }
}
