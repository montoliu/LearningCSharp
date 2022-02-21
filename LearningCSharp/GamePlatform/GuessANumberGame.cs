namespace GamePlatform;

public class GuessANumberGame : Game
{
    public GuessANumberGame()
    {
        _gameState    = new GuessANumberGameGameState();
        _forwardModel = new GuessANumberGameForwardModel();
    }

}