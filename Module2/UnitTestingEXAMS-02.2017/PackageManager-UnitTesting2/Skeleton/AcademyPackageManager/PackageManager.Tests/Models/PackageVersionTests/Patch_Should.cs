using NUnit.Framework;
using PackageManager.Enums;
using PackageManager.Models;
using System;

namespace PackageManager.Tests.Models.PackageVersionTests
{
    [TestFixture]
    public class Patch_Should
    {
        [Test]
        public void SetThePassedValue_IfItIsValid()
        {
            int major = 1;
            int minor = 2;
            int patch = 3;
            VersionType type = VersionType.alpha;

            var packageVersion = new PackageVersion(major, minor, patch, type);

            Assert.AreEqual(patch, packageVersion.Patch);
        }

        [Test]
        public void ThrowArgumentException_IfInvalidValueIsPassed()
        {
            int major = 1;
            int minor = 2;
            int patch = -4;
            VersionType type = VersionType.alpha;

            Assert.Throws<ArgumentException>(() => new PackageVersion(major, minor, patch, type));
        }
    }
}
