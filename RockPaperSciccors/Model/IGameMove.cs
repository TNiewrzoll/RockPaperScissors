namespace RockPaperSciccors.Model
{
    public enum HandGesture
    {
        Rock,
        Paper,
        Scissors
    }

    public interface IGameMove
    {
        public HandGesture PlayerGesture { get; set; }

        public HandGesture AIGesture { get; set; }

        public GameState GameState { get; set; }

    }
}
