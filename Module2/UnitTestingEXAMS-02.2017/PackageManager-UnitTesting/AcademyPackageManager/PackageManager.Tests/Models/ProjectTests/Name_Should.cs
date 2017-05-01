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
    public class Name_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenPassedValueIsNull()
        {
            //Arrange, Act & Assert
            Assert.Throws<ArgumentNullException>(() => new Project(null, "ei tam"));
        }

        [Test]
        public void SetName_WhenPassedValueIsValid()
        {
            //Arrange
            string name = "ivan";

            //Act
            var project = new Project(name, "ei tam");

            //Assert
            Assert.AreEqual(name, project.Name);
        }
    }
}
