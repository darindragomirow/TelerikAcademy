using Academy.Core.Contracts;
using Academy.Models.Contracts;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Adding
{
    [TestFixture]
    public class Execute_Should
    {
        [Test]
        public void AddStudent_WhenStudentIsAlreadeyInTheSeason()
        {
            //Arrange
            var factoryMock = new Mock<IAcademyFactory>();
            var engineMock = new Mock<IEngine>();

            var studentMock = new Mock<IStudent>();

            studentMock.SetupGet(x => x.Username).Returns("Pesho");
            engineMock.SetupGet(x => x.Students).Returns(new List<IStudent>()
            {studentMock.Object });

            var seasonMock = new Mock<ISeason>();

            seasonMock.SetupGet(x => x.Students).Returns(new List<IStudent>() { studentMock.Object });

            engineMock.SetupGet(x => x.Seasons).Returns(new List<ISeason>() { seasonMock.Object });

            var command = new AddToSeasonCommandMock(factoryMock.Object, engineMock.Object);

            //Act & Assert
            Assert.Throws<ArgumentException>
                (() => command.Execute(new List<string>() { "Pesho", "0" }));
        }
    }
}
