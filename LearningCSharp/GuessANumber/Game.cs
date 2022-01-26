namespace GuessANumber;

public class Game
{
    private GameState    _gameState;      // state of the game
    private ForwardModel _forwardModel;   // rules of the game

    public Game(int maxNumberToGuess, int maxTries)
    {
        _gameState    = new GameState();
        _forwardModel = new ForwardModel();

        _gameState.SetMaxNumberToGuess(maxNumberToGuess);
        _gameState.SetMaxTries(maxTries);
    }

    public void Run(Player player)
    {
        Console.WriteLine("Let's play to Guess a Number between 1 and " + _gameState.GetMaxNumberToGuess() + "!");

        _gameState.Reset();
        while (!_gameState.IsTerminal())
        {
            Action action = player.Think(_gameState);                          // player selects an action
            Console.WriteLine("Player select action: " + action.ToString());
            int reward = _forwardModel.Play(_gameState, action);               // Play the action
            switch (reward)
            {
                case -1:
                    Console.WriteLine("You failed, the number is smaller. Number of remaining tries: " + _gameState.GetRemainingTries());
                    break;
                case 1:
                    Console.WriteLine("You failed, the number is greater. Number of remaining tries: " + _gameState.GetRemainingTries());
                    break;
                default:
                    Console.WriteLine("Congratulations, you guessed the number after " + _gameState.GetTry() + " tries");
                    break;
            }
        }
        if (!_gameState.IsPlayerWon())
            Console.WriteLine("I'm sorry, you didn't guess the number.");
    }
}