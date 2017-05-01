using NUnit.Framework;
using PackageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.ProjectTests
{
    [TestFixture]
    public class Location_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenPassedValueIsNull()
        {
            //Arrange, Act & Assert
            Assert.Throws<ArgumentNullException>(() => new Project("ivan", null));
        }

        [Test]
        public void SetName_WhenPassedValueIsValid()
        {
            //Arrange
            string location = "ei tam";

            //Act
            var project = new Project("ivan", location);

            //Assert
            Assert.AreEqual(location, project.Location);
        }
    }
}
