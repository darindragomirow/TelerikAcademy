using NUnit.Framework;
using PackageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.PackageTests
{
    [TestFixture]
    class PropertiesTests
    {
        [Test]
        public void Name_IsSetCorrectly()
        {
            var version = new PackageVersion(1, 2, 3, Enums.VersionType.alpha);
            var sut = new Package("Valid Name", version, null);
         

            Assert.AreEqual("Valid Name", sut.Name);
        }
        [Test]
        public void Version_IsSetCorrectly()
        {
            var version = new PackageVersion(1, 2, 3, Enums.VersionType.alpha);
            var sut = new Package("Valid Name", version, null);

            Assert.AreEqual(version, sut.Version);
        }
        [Test]
        public void Url_IsSetCorrectly()
        {
            var version = new PackageVersion(1, 2, 3, Enums.VersionType.alpha);
            var Url = string.Format("{0}.{1}.{2}-{3}", version.Major, version.Minor,
               version.Patch, version.VersionType);

            var sut = new Package("Valid Name", version, null);

            Assert.AreEqual(Url, sut.Url);
        }
    }
}
