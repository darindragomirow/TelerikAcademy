using NUnit.Framework;
using PackageManager.Enums;
using PackageManager.Models;
using System;

namespace PackageManager.Tests.Models.PackageVersionTests
{
    [TestFixture]
    public class Minor_Should
    {
        [Test]
        public void SetThePassedValue_IfItIsValid()
        {
            int major = 1;
            int minor = 1;
            int patch = 1;
            VersionType type = VersionType.alpha;

            var packageVersion = new PackageVersion(major, minor, patch, type);

            Assert.AreEqual(minor, packageVersion.Minor);
        }

        [Test]
        public void ThrowArgumentException_IfInvalidValueIsPassed()
        {
            int major = 1;
            int minor = -1;
            int patch = 1;
            VersionType type = VersionType.alpha;

            Assert.Throws<ArgumentException>(() => new PackageVersion(major, minor, patch, type));
        }
    }
}
