using Moq;
using NUnit.Framework;
using PackageManager.Core;
using PackageManager.Core.Contracts;
using PackageManager.Enums;
using PackageManager.Info.Contracts;
using PackageManager.Models;
using PackageManager.Models.Contracts;
using PackageManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Core.PackageInstallerTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void CallRestoringPackagesMethod()
        {
            //Package for dependancy 1
            var namePackageForDependancyOne = "JS package";
            var versionMockForPackageForDependacyOne = new Mock<IVersion>();
            versionMockForPackageForDependacyOne.SetupGet(x => x.Major).Returns(1);
            versionMockForPackageForDependacyOne.SetupGet(x => x.Minor).Returns(2);
            versionMockForPackageForDependacyOne.SetupGet(x => x.Patch).Returns(3);
            versionMockForPackageForDependacyOne.SetupGet(x => x.VersionType).Returns(VersionType.rc);
            var packageDependancyOne = new Package(namePackageForDependancyOne, versionMockForPackageForDependacyOne.Object);


            //Package for dependancy 2
            var namePackageForDependancyTwo = "C# package";
            var versionMockForPackageForDependacyTwo = new Mock<IVersion>();
            versionMockForPackageForDependacyTwo.SetupGet(x => x.Major).Returns(4);
            versionMockForPackageForDependacyTwo.SetupGet(x => x.Minor).Returns(3);
            versionMockForPackageForDependacyTwo.SetupGet(x => x.Patch).Returns(1);
            versionMockForPackageForDependacyTwo.SetupGet(x => x.VersionType).Returns(VersionType.alpha);

            var packageDependancyTwo = new Package(namePackageForDependancyTwo, versionMockForPackageForDependacyTwo.Object);

            //Package with dependances
            var namePackageWithDependancy = "Package with dependancies";
            var versionMockForPackageWithDependacy = new Mock<IVersion>();
            versionMockForPackageWithDependacy.SetupGet(x => x.Major).Returns(8);
            versionMockForPackageWithDependacy.SetupGet(x => x.Minor).Returns(2);
            versionMockForPackageWithDependacy.SetupGet(x => x.Patch).Returns(1);
            versionMockForPackageWithDependacy.SetupGet(x => x.VersionType).Returns(VersionType.final);

            var setOfDependancyPackages = new HashSet<IPackage>
            {
                packageDependancyOne,
                packageDependancyTwo
            };
            
            var packageWithDependacies = new Package(
                namePackageWithDependancy, 
                versionMockForPackageWithDependacy.Object,
                setOfDependancyPackages);

            var loggerMock = new Mock<ILogger>();
            var setOfPackagesForPackageRepo = new HashSet<IPackage> { packageWithDependacies };

            var packageRepo = new PackageRepository(loggerMock.Object, setOfPackagesForPackageRepo);

            var projectMock = new Mock<IProject>();
            projectMock.SetupGet(x => x.PackageRepository).Returns(packageRepo);

            var downloaderMock = new Mock<IDownloader>();

            var packageInstaller = new PackageInstaller(downloaderMock.Object, projectMock.Object);





                //PackageInstaller(IDownloader downloader, IProject project)
                // PackageRepository(ILogger logger, ICollection < IPackage > packages = null) - HashSet<IPackage>();

            //Package(string name, IVersion version, ICollection<IPackage> dependencies = null) - HashSet<IPackage>
            //2 packages for dependancies




        }
    }
}
