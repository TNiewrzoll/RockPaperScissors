namespace RockPaperSciccors.Model
{
    public enum GameState
    {
        Loss,
        draw,
        win
    }

    public interface IGameLogic
    {
        /// <summary>
        /// this function is for the basic gamelogic
        /// </summary>
        /// <returns>Returns the actual gamestate</returns>
        GameState PlayRockPaperSciccors(IGameMove gesture);
    }
}
