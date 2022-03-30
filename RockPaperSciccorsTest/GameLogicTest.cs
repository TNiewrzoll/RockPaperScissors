using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperSciccors.Model;
using RockPaperSciccors.Service;

namespace RockPaperSciccorsTest
{
    [TestClass]
    public class GameLogicTest
    {

        public GameLogicTest()
        {
        }

        [TestMethod]
        public void RockDrawWithRock()
        {
            var mockIGameMove = new Moq.Mock<IGameMove>();
            var Gamelogic = new GameLogic();

            mockIGameMove.Setup(x => x.PlayerGesture).Returns(HandGesture.Rock);
            mockIGameMove.Setup(x => x.AIGesture).Returns(HandGesture.Rock);
            mockIGameMove.Setup(x => x.GameState).Returns(Gamelogic.PlayRockPaperSciccors(mockIGameMove.Object));

            Assert.AreEqual(mockIGameMove.Object.GameState, GameState.draw);
        }

        [TestMethod]
        public void RockLoseWithPaper()
        {
            var mockIGameMove = new Moq.Mock<IGameMove>();
            var Gamelogic = new GameLogic();

            mockIGameMove.Setup(x => x.PlayerGesture).Returns(HandGesture.Rock);
            mockIGameMove.Setup(x => x.AIGesture).Returns(HandGesture.Paper);
            mockIGameMove.Setup(x => x.GameState).Returns(Gamelogic.PlayRockPaperSciccors(mockIGameMove.Object));

            Assert.AreEqual(mockIGameMove.Object.GameState, GameState.Loss);
        }

        [TestMethod]
        public void RockWinWithScissor()
        {
            var mockIGameMove = new Moq.Mock<IGameMove>();

            mockIGameMove.Setup(x => x.PlayerGesture).Returns(HandGesture.Rock);
            mockIGameMove.Setup(x => x.AIGesture).Returns(HandGesture.Scissors);

            Assert.AreEqual(new GameLogic().PlayRockPaperSciccors(mockIGameMove.Object), GameState.win);
        }

        [TestMethod]
        public void ScissorssDrawWithScissor()
        {
            var mockIGameMove = new Moq.Mock<IGameMove>();

            mockIGameMove.Setup(x => x.PlayerGesture).Returns(HandGesture.Scissors);
            mockIGameMove.Setup(x => x.AIGesture).Returns(HandGesture.Scissors);

            Assert.AreEqual(new GameLogic().PlayRockPaperSciccors(mockIGameMove.Object), GameState.draw);
        }

        [TestMethod]
        public void ScissorssWinsWithPaper()
        {
            var mockIGameMove = new Moq.Mock<IGameMove>();

            mockIGameMove.Setup(x => x.PlayerGesture).Returns(HandGesture.Scissors);
            mockIGameMove.Setup(x => x.AIGesture).Returns(HandGesture.Paper);

            Assert.AreEqual(new GameLogic().PlayRockPaperSciccors(mockIGameMove.Object), GameState.win);
        }

        [TestMethod]
        public void ScissorsLoseWithRock()
        {
            var mockIGameMove = new Moq.Mock<IGameMove>();

            mockIGameMove.Setup(x => x.PlayerGesture).Returns(HandGesture.Scissors);
            mockIGameMove.Setup(x => x.AIGesture).Returns(HandGesture.Rock);

            Assert.AreEqual(new GameLogic().PlayRockPaperSciccors(mockIGameMove.Object), GameState.Loss);
        }

        [TestMethod]
        public void PaperLoseWithScissor()
        {
            var mockIGameMove = new Moq.Mock<IGameMove>();

            mockIGameMove.Setup(x => x.PlayerGesture).Returns(HandGesture.Paper);
            mockIGameMove.Setup(x => x.AIGesture).Returns(HandGesture.Scissors);

            Assert.AreEqual(new GameLogic().PlayRockPaperSciccors(mockIGameMove.Object), GameState.Loss);
        }

        [TestMethod]
        public void PaperDrawWithPaper()
        {
            var mockIGameMove = new Moq.Mock<IGameMove>();

            mockIGameMove.Setup(x => x.PlayerGesture).Returns(HandGesture.Paper);
            mockIGameMove.Setup(x => x.AIGesture).Returns(HandGesture.Paper);

            Assert.AreEqual(new GameLogic().PlayRockPaperSciccors(mockIGameMove.Object), GameState.draw);
        }

        [TestMethod]
        public void PaperWinsWithRock()
        {
            var mockAI = new Moq.Mock<IAI>();
            var mockIGameMove = new Moq.Mock<IGameMove>();

            mockIGameMove.Setup(x => x.PlayerGesture).Returns(HandGesture.Paper);
            mockIGameMove.Setup(x => x.AIGesture).Returns(HandGesture.Rock);

            Assert.AreEqual(new GameLogic().PlayRockPaperSciccors(mockIGameMove.Object), GameState.win);
        }

    }
}
