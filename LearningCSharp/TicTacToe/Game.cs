namespace TicTacToe;

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
        Console.WriteLine("Let's play to TicTacToe");
        
        int firstPlayer = 1;
        _gameState.Reset(firstPlayer);
        
        while (!_gameState.IsTerminal())
        {
            Console.WriteLine("\nTurn of player " + _gameState.GetTurn());
            Console.WriteLine(_gameState.BoardToStr());
            
            Action action = player.Think(_gameState);                          // player selects an action
            Console.WriteLine("Player " + _gameState.GetTurn() + " selected place: " + action);
            int reward = _forwardModel.Play(_gameState, action);               // Play the action
        }

        int winner = _gameState.GetWinner();
        if (winner != 0)
            Console.WriteLine("The Winner is the player " + winner);
        else
            Console.WriteLine("Tie");
        Console.WriteLine(_gameState.BoardToStr());
    }

}