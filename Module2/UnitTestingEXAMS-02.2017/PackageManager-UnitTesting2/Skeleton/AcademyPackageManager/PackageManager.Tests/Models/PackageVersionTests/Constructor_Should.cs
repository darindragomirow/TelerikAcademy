using NUnit.Framework;
using PackageManager.Enums;
using PackageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.PackageVersionTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void SetsTheAppropriatePassedValues()
        {
            int major = 1;
            int minor = 1;
            int patch = 1;
            VersionType type = VersionType.alpha;

            var packageVersion = new PackageVersion(major, minor, patch, type);

            Assert.AreEqual(major, packageVersion.Major);
            Assert.AreEqual(minor, packageVersion.Minor);
            Assert.AreEqual(patch, packageVersion.Patch);
            Assert.AreEqual(type, packageVersion.VersionType);
        }
    }
}
