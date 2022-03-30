namespace RockPaperSciccors.Model
{
    public class GameMove : IGameMove
    {
        #region Declaration
        private HandGesture handGesture;
        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public GameMove() { }

        public GameMove(HandGesture handGesture)
        {
            this.handGesture = handGesture;
        }
        #endregion

        #region Properties
        public HandGesture PlayerGesture { get; set; }
        public HandGesture AIGesture { get; set; }
        public GameState GameState { get; set; }
        #endregion

    }
}
