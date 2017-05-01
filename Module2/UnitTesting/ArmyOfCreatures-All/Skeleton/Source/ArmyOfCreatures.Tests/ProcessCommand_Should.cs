using System;
using NUnit.Framework;
using ArmyOfCreatures.Console.Commands;
using Moq;
using ArmyOfCreatures.Logic.Battles;

namespace ArmyOfCreatures.Tests
{
    [TestFixture]
    public class ProcessCommand_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenBattleManagerIsNull()
        {
            //Arrange
            var command = new AddCommand();
            string[] parameters = { "par1", "par2" };

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => command.ProcessCommand(null, parameters));         
        }

        [Test]
        public void ThrowArgumentNullException_WhenParamsAreNull()
        {
            //Arrange
            var command = new AddCommand();
            var battleManagerMock = new Mock<IBattleManager>();
            string[] parameters = null;
            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => command.ProcessCommand(battleManagerMock.Object, parameters));
        }
        [Test]
        public void ThrowArgumentException_WhenTheNumberOfParamsIsInvalid()
        {
            //Arrange
            var command = new AddCommand();
            var battleManagerMock = new Mock<IBattleManager>();
            string[] parameters = {"1"};
         
            //Act & Assert
            Assert.Throws<ArgumentException>(() => command.ProcessCommand(battleManagerMock.Object, parameters));

        }
        [Test]
        public void AddCreatures_WhenTheCommandIsParsedSuccessfully()
        {
            var command = new AddCommand();
            var battleManagerMock = new Mock<IBattleManager>();
            string[] parameters = new string[] { "5", "someCreature(1)" };

           // var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            //Act
            command.ProcessCommand(battleManagerMock.Object, parameters);

            //Assert
            battleManagerMock.Verify(x => x.AddCreatures(It.IsAny<CreatureIdentifier>(),5),Times.Once);

        }
    }
}
