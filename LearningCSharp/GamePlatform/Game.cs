namespace GamePlatform;

public class Game
{
    protected iGameState    _gameState;      // state of the game
    protected iForwardModel _forwardModel;   // rules of the game
    
    // Generic Run workflow for all games
    public void Run(iPlayer player)
    {
        _gameState.Reset();
        while (!_gameState.IsTerminal())
        {
            Console.WriteLine("\n" + _gameState);                          // Show game state
            Action action = player.Think(_gameState);                      // player selects an action
            Console.WriteLine("Player selected: " + action.ToString());    // Show the action played
            int reward = _forwardModel.Play(_gameState, action);           // Play the action
            Console.WriteLine(_gameState.GetRewardInformation(reward));    // Show information after action is played
        }
        Console.WriteLine(_gameState);
    }
}