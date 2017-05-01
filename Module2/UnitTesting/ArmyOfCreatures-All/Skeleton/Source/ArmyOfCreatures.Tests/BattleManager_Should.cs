using ArmyOfCreatures.Logic;
using ArmyOfCreatures.Logic.Battles;
using ArmyOfCreatures.Logic.Creatures;
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
    class BattleManager_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenIdentifierIsNull()
        {
            //Arrange
            var factoryMock = new Mock<ICreaturesFactory>();
            var loggerMock = new Mock<ILogger>();
            var battleManager = new BattleManager(factoryMock.Object, loggerMock.Object);

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => battleManager.AddCreatures(null, 1));

        }
        [Test]
        public void CallCreateCreature_FromFactory()
        {
            // Arrange
            var mockedFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();
            var creature = new Angel();

            var battleManager = new BattleManager(mockedFactory.Object, mockedLogger.Object);
            mockedFactory.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            // Act
            battleManager.AddCreatures(identifier, 1);

            // Assert
            mockedFactory.Verify(x => x.CreateCreature(It.IsAny<string>()), Times.Exactly(1));
        }
        [Test]
        public void CallWriteLineFromLogger_WhenAddCreatures()
        {
            var factoryMock = new Mock<ICreaturesFactory>();
            var loggerMock = new Mock<ILogger>();
            var battleManager = new BattleManager(factoryMock.Object, loggerMock.Object);
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");
            var creature = new Angel();

            factoryMock.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);
            loggerMock.Setup(x => x.WriteLine(It.IsAny<string>()));

            //Act
            battleManager.AddCreatures(identifier, 1);

            //Assert
            loggerMock.Verify(x => x.WriteLine(It.IsAny<string>()), Times.Once);
        }
        [Test]
        public void ThrowArgumentException_WhenPassedInvalidIdentifier()
        {
            //Arrange
            Mock<ICreaturesFactory> factoryMock = new Mock<ICreaturesFactory>();
            var loggerMock = new Mock<ILogger>();
            var battleManager = new BattleManager(factoryMock.Object, loggerMock.Object);
            var invalidID = CreatureIdentifier.CreatureIdentifierFromString("Angel(3)");
            var creature = new Archangel();
            factoryMock.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);

            //Act & Assert
            Assert.Throws<ArgumentException>(() => battleManager.AddCreatures(invalidID, 1));
        }
        [Test]
        public void CallWriteLineExactly6Times_WhenAttack()
        {
            //Arrange
            var loggerMock = new Mock<ILogger>();
            var factoryMock = new Mock<ICreaturesFactory>();
            var battleManager = new BattleManager(factoryMock.Object,loggerMock.Object);
            var deffenderID = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");
            var attackerID = CreatureIdentifier.CreatureIdentifierFromString("Angel(2)");
            var creature = new Angel();

            factoryMock.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);
            loggerMock.Setup(x => x.WriteLine(It.IsAny<string>()));

            
            battleManager.AddCreatures(deffenderID, 1);
            battleManager.AddCreatures(attackerID, 1);

            //Act
            battleManager.Attack(attackerID, deffenderID);

            //Assert
            loggerMock.Verify(x => x.WriteLine(It.IsAny<string>()), Times.Exactly(6));
        }
    }
}
