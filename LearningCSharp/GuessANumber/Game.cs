namespace GuessANumber;

public class Game
{
    private GameState    _game_state;
    private ForwardModel _forward_model;

    public Game(int maxNumberToGuess, int maxIterations)
    {
        _game_state    = new GameState();
        _forward_model = new ForwardModel();

        _game_state.SetMaxNumberToGuess(maxNumberToGuess);
        _game_state.SetMaxIterations(maxIterations);
    }

    public void Run(Player player)
    {
        Console.WriteLine("Let's play to Guess a Number between 1 and " + _game_state.GetMaxNumberToGuess() + " !");

        _game_state.reset();
        int max_iter = 10;, 
        String s = new String("");
        int    n;
        while (!_game_state.isTerminal())
        {
            Action action = player.Think(_game_state);
            _forward_model.Play(_game_state, action);
        }
    }
}