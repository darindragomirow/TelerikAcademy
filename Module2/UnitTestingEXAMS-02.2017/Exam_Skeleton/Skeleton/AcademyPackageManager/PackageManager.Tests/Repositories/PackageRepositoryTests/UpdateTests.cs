using Moq;
using NUnit.Framework;
using PackageManager.Info.Contracts;
using PackageManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Repositories.PackageRepositoryTests
{
    [TestFixture]
    class UpdateTests
    {
        [Test]
        public void UpdatePackage_WhenPackageIsInvalid()
        {
            
       
            var loggerMock = new Mock<ILogger>();
            var sut = new PackageRepository(loggerMock.Object, null);

            //Act & Assert
            var ex = NUnit.Framework.Assert.Throws<ArgumentNullException>(() => sut.Update(null));
            NUnit.Framework.StringAssert.Contains("cannot be null", ex.Message);
        
    }
    }
}
