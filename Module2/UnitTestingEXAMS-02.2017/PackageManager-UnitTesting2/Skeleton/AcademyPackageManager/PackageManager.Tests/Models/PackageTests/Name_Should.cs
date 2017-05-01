using Moq;
using NUnit.Framework;
using PackageManager.Models;
using PackageManager.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.PackageTests
{
    [TestFixture]
    public class Name_Should
    {
        [Test]
        public void SetCorrectlyThePassedValue()
        {
            var name = "Some package";
            var versionMock = new Mock<IVersion>();

            var package = new Package(name, versionMock.Object);

            Assert.AreEqual(name, package.Name);
        }
    }
}
