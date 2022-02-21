namespace GamePlatform;

public class Game
{
    protected iGameState    _gameState;      // state of the game
    protected iForwardModel _forwardModel;   // rules of the game
    
    public Game()
    {
        _gameState    = new iGameState();
        _forwardModel = new iForwardModel();
    }

    public void Run(Player player)
    {
        _gameState.Reset();
        while (!_gameState.IsTerminal())
        {
            Action action = player.Think(_gameState); // player selects an action
            Console.WriteLine("Player selected action: " + action.ToString());
            int reward = _forwardModel.Play(_gameState, action); // Play the action
        }
    }
}