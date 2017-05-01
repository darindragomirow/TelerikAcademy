using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Models.Abstractions
{
    [TestFixture]
    public class UsertTest
    {
        [Test]
        public void ReturnProperName_WhenGetMethodIsCalled()
        {
            //Arrange
            var user = new UserMock("Pesho");

            //Act
            var result = user.Username;

            //Assert
            Assert.AreEqual(result, "Pesho");

        }
    }
}
