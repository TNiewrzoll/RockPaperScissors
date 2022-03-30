using RockPaperSciccors.Model;

namespace RockPaperSciccors.Service
{
    public interface IGameService
    {
        public void SetValues(HandGesture  playerGesture, AILevel aILevel);

        public IGameMove StartGame();
    }
}
