using Moq;
using NUnit.Framework;
using PackageManager.Info.Contracts;
using PackageManager.Models.Contracts;
using PackageManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Repositories.PackageRepositoryTest
{
    [TestFixture]
    public class Delete_Should
    {
        [Test]
        public void ThrowArgumentNullException_IfPassedPackageIsNull()
        {
            var loggerMock = new Mock<ILogger>();
            var packageMock = new Mock<IPackage>();
            var setOfPackages = new HashSet<IPackage> { packageMock.Object };

            var packageRepo = new PackageRepository(loggerMock.Object, setOfPackages);

            Assert.Throws<ArgumentNullException>(() => packageRepo.Delete(null));
        }
    }
}
