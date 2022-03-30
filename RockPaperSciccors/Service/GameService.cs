using Microsoft.Extensions.DependencyInjection;
using RockPaperSciccors.Model;

namespace RockPaperSciccors.Service
{
    public class GameService : IGameService
    {
        #region Declaration

        private IGameLogic _gameLogic;
        private IGameMove _gameMove;
        private IAI _aI;

        #endregion

        #region Constructor
        public GameService() { }

        public GameService(IGameLogic gameLogic, IGameMove gesture, IAI aI)
        {
            _gameLogic = gameLogic;
            _gameMove = gesture;
            _aI = aI;
        }
        #endregion

        #region Functions

        public void SetValues(HandGesture playerGesture, AILevel aILevel)
        {
            _gameMove.PlayerGesture = playerGesture;
            _gameMove.AIGesture = _aI.MakeDecision(aiLevel: aILevel, playerHandgesture: playerGesture);
        }

        public IGameMove StartGame()
        {
            this._gameMove.GameState = _gameLogic.PlayRockPaperSciccors(_gameMove);
            return this._gameMove;
        }

        #endregion
    }
}