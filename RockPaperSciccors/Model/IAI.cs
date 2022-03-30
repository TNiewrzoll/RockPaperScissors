namespace RockPaperSciccors.Model
{
    public enum AILevel
    {
        Easy = 0,
        Medium = 1,
        Insane = 2
    }

    public interface IAI
    {
        public HandGesture MakeDecision(AILevel  aiLevel, HandGesture playerHandgesture);
    }
}
