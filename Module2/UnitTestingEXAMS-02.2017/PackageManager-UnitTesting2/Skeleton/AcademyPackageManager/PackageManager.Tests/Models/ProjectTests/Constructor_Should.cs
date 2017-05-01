using Moq;
using NUnit.Framework;
using PackageManager.Models;
using PackageManager.Models.Contracts;
using PackageManager.Repositories.Contracts;

namespace PackageManager.Tests.Models.ProjectTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void SetCorrectly_OptionalParameterPackages_ForPackageRepository()
        {
            var project = new Project("JSPackage", "ServerA");

            Assert.IsInstanceOf<IRepository<IPackage>>(project.PackageRepository);
        }

        [Test]
        public void SetCorrectly_PassedParameterPackages_ForPackageRepository()
        {
            var repoWithPackagesMock = new Mock<IRepository<IPackage>>();
            var project = new Project("JSPackage", "ServerA", repoWithPackagesMock.Object);

            Assert.IsInstanceOf<IRepository<IPackage>>(project.PackageRepository);
            Assert.AreSame(repoWithPackagesMock.Object, project.PackageRepository);
        }
    }
}
