using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperSciccors.Model;
using RockPaperSciccors.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsTest
{
    [TestClass]
    public class GameServiceTest
    {
        public GameServiceTest() { }

        [TestMethod]
        public void Lose100TimesAgainstHardAI()
        {
            var mockAI = new Moq.Mock<AI>();
            var mockGesture = new Moq.Mock<GameMove>();
            var mockGameLogic = new Moq.Mock<GameLogic>();

            GameService gameService = new GameService(mockGameLogic.Object, mockGesture.Object, mockAI.Object);

            for (int i = 0; i < 100; i++)
            {
                //Setup an random Handgesture for the player
                gameService.SetValues((HandGesture)Enum.GetValues(typeof(HandGesture)).GetValue(new Random().Next(0, 3)), AILevel.Insane);

                var res = gameService.StartGame();
                if (res.GameState == GameState.win || res.GameState == GameState.draw)
                    Assert.Fail();
            }
        }
    }
}
