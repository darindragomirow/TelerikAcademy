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
    public class VersionType_Should
    {
        [Test]
        public void SetThePassedValue_IfItIsValid()
        {
            int major = 1;
            int minor = 2;
            int patch = 3;
            VersionType type = VersionType.alpha;

            var packageVersion = new PackageVersion(major, minor, patch, type);

            Assert.AreEqual(type, packageVersion.VersionType);
        }

        [Test]
        public void ThrowArgumentException_IfInvalidValueIsPassed()
        {
            int major = 1;
            int minor = 2;
            int patch = 4;
            VersionType type = ((VersionType)Int32.MaxValue);

            Assert.Throws<ArgumentException>(() => new PackageVersion(major, minor, patch, type));
        }

    }
}
