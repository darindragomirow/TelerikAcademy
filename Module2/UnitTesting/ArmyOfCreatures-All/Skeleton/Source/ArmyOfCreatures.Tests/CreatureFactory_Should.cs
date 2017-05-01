using ArmyOfCreatures.Logic;
using ArmyOfCreatures.Logic.Creatures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Tests
{   
    [TestFixture]
    class CreatureFactory_Should
    {
        [Test]
        public void ThrowArgumentException_WithMessage_WhenInvalidValueIsPassed()
        {
            var sut = new CreaturesFactory();
            var invalidString= "Invalid value";

            //Act & Assert
            var ex = "Invalid";
            var act = Assert.Throws<ArgumentException>(() => sut.CreateCreature(invalidString));
            StringAssert.Contains(ex, act.Message);
        }
        [Test]
        public void ReturnCreatureType_BasedOnTheStringThatIsPassed()
        {
            //Arrange
            var sut = new CreaturesFactory();

            //Act
            var result=sut.CreateCreature("Angel");

            //Assert
            Assert.IsInstanceOf<Angel>(result);
        }
    }
}
