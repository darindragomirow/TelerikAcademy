using Academy.Core.Contracts;
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
    public class Constructor_Should
    {
        [Test]
        public void SetFactory_WhenPassedFactoryIsNotNull()
        {
            var factoryMock = new Mock<IAcademyFactory>();
            var engineMock = new Mock<IEngine>();

            var command = new AddToSeasonCommandMock(factoryMock.Object, engineMock.Object);

            //Assert
            Assert.AreSame(factoryMock.Object, command.AcademyFactory);
        }
    }
}
    