namespace RockPaperSciccors.Model
{
    public class GameLogic : IGameLogic
    {
        #region Constructor
        public GameLogic() { }
        #endregion

        #region Functions
        public GameState PlayRockPaperSciccors(IGameMove gameMove)
        {
            return GetGameresult(gameMove: gameMove);
        }

        /// <summary>
        /// //Implementation of the gamerules
        /// </summary>
        /// <param name="player"></param>
        /// <param name="aIGesture"></param>
        /// <returns></returns>
        private GameState GetGameresult(IGameMove gameMove)
        {
            GameState returnState = GameState.Loss;

            switch (gameMove.PlayerGesture)
            {
                case HandGesture.Rock:
                    switch (gameMove.AIGesture)
                    {
                        case HandGesture.Rock:
                            returnState = GameState.draw;
                            break;
                        case HandGesture.Paper:
                            returnState = GameState.Loss;
                            break;
                        case HandGesture.Scissors:
                            returnState = GameState.win;
                            break;
                    }
                    break;
                case HandGesture.Paper:
                    switch (gameMove.AIGesture)
                    {
                        case HandGesture.Rock:
                            returnState = GameState.win;
                            break;
                        case HandGesture.Paper:
                            returnState = GameState.draw;
                            break;
                        case HandGesture.Scissors:
                            returnState = GameState.Loss;
                            break;
                    }
                    break;
                case HandGesture.Scissors:
                    switch (gameMove.AIGesture)
                    {
                        case HandGesture.Rock:
                            returnState = GameState.Loss;
                            break;
                        case HandGesture.Paper:
                            returnState = GameState.win;
                            break;
                        case HandGesture.Scissors:
                            returnState = GameState.draw;
                            break;
                    }
                    break;
            }

            return returnState;
        }
        #endregion
    }
}
