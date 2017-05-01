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
    class Properties
    {
        [Test]
        public void Name_IsSetCorrectly_WhenCreateProject()
        {
            //Arrange
            var sut = new Project("Valid Name", "Sofia", null);
            var result = sut.Name;

            //Assert
            Assert.AreEqual("Valid Name", result);
        }
        [Test]
        public void Location_IsSetCorrectly_WhenCreateProject()
        {
            //Arrange
            var sut = new Project("Valid Name", "Sofia", null);
            var result = sut.Location;

            //Assert
            Assert.AreEqual("Sofia", result);
        }
    }
}
