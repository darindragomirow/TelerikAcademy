using ArmyOfCreatures.Logic.Battles;
using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Logic.Specialties;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyOfCreatures.Tests
{
    [TestFixture]
    public class DoubleDefens_WhenDefending_Should
    {
        [Test]
        public void ThrowArgumentNullException()
        {
            //Arrange
            var sut = new DoubleDefenseWhenDefending(1);
            var attackerMock = new Mock<ICreaturesInBattle>();
            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => sut.ApplyWhenDefending(null, attackerMock.Object));
        }

        [Test]
        public void MultiplyBy2_CurrentDefenseProperty_WhenTheEffectIsNotExpired()
        {
            //Arrange
            var sut = new DoubleDefenseWhenDefending(3);
            var attackerMock = new Mock<ICreaturesInBattle>();
            var creature = new Angel();
            var deffenderWithSpeciality = new CreaturesInBattle(creature, 5);
            deffenderWithSpeciality.CurrentDefense = 30;
            
            //Act
            sut.ApplyWhenDefending(deffenderWithSpeciality, attackerMock.Object);

            //Assert
            Assert.AreEqual(60, deffenderWithSpeciality.CurrentDefense);
        }
    }
}
