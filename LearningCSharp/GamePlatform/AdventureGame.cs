namespace GamePlatform;

public class AdventureGame : Game
{
    public AdventureGame()
    {
        _gameState    = new AdventureGameState();
        _forwardModel = new AdventureForwardModel();
    }

}