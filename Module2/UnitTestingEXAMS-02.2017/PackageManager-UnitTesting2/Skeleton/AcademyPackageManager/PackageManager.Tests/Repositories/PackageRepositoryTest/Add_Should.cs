using Moq;
using NUnit.Framework;
using PackageManager.Info.Contracts;
using PackageManager.Models.Contracts;
using PackageManager.Repositories;
using System;
using System.Collections.Generic;

namespace PackageManager.Tests.Repositories.PackageRepositoryTest
{
    [TestFixture]
    public class Add_Should
    {
        [Test]
        public void ThrowArgumentNullException_IfPassedPackageIsNull()
        {
            var loggerMock = new Mock<ILogger>();
            var packageMock = new Mock<IPackage>();
            var setOfPackages = new HashSet<IPackage> { packageMock.Object };

            var packageRepo = new PackageRepository(loggerMock.Object, setOfPackages);

            Assert.Throws<ArgumentNullException>(() => packageRepo.Add(null));
        }
    }
}
