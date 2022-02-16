namespace Adventure;

public class Game
{
    private GameState    _gameState;      // state of the game
    private ForwardModel _forwardModel;   // rules of the game

    public Game()
    {
        _gameState    = new GameState();
        _forwardModel = new ForwardModel();
    }
    
    public void Run(Player player)
    {
        _gameState.Reset();
        while (!_gameState.IsTerminal())
        {
            Console.WriteLine("\n" + _gameState.GetMessage());
            Action action = player.Think(_gameState);                          // player selects an action
            Console.WriteLine("Player selected action: " + action.ToString());
            int reward = _forwardModel.Play(_gameState, action);               // Play the action
        }
        Console.WriteLine(_gameState.GetMessage());
    }
}
