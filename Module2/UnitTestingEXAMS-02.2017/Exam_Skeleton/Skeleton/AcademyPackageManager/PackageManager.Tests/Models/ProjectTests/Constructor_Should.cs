using NUnit.Framework;
using PackageManager.Info;
using PackageManager.Models;
using PackageManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.ProjectTests
{
    [TestFixture]
    class Constructor_Should
    {
        [Test]
        public void SetPackageRepositoryCorrectly_WhenOptionalPackagesIsPassed()
        {
         //   var packageRepository = new PackageRepository
       //     var sut = new Project("blabla", "Sofia",packageRepository);
        
        //Assert.AreEqual(sut.PackageRepository,packageRepository);
        }
        [Test]
        public void SetPackageRepositoryCorrectly_WhenPackagesIsNotPassed()
        {
            var sut = new Project("blabla", "Sofia");

            Assert.IsNotNull(sut.PackageRepository);
        }

    }
    
    
}
