namespace GamePlatform;

public class GuessANumberGame : Game
{
    public GuessANumberGame()
    {
        _gameState    = new GuessANumberGameState();
        _forwardModel = new GuessANumberForwardModel();
    }
    
    public void SetMaxNumberToGuess(int maxNumberToGuess)
    {
        ((GuessANumberGameState) _gameState).SetMaxNumberToGuess(maxNumberToGuess);
    }

    public void SetMaxTries(int maxTries)
    {
        ((GuessANumberGameState) _gameState).SetMaxTries(maxTries);
    }
}