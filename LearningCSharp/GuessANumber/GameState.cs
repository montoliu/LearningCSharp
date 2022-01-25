namespace GuessANumber;

public class GameState
{
    private int  _number_to_guess;
    private int  _max_number_to_guess;
    private int  _max_interations;
    private int  _iteration;
    private bool _player_won;
    public GameState()
    {ameayeraeayer
        _player_won = false;
        _iteration  = 1;
    }

    public List<Action> GetAllPossibleActions()
    {
        List<Action> l = new List<Action>();

        for (int i = 0; i < 100; i++)
        {
            Action a = new Action(i);
            l.Add(a);
        }

        return l;
    }

    public void reset()
    {
        Random random = new Random();
        _number_to_guess = random.Next(_max_number_to_guess) + 1;
    }

    public int GetMaxNumberToGuess()
    {
        return _max_number_to_guess;
    }

    public void SetMaxNumberToGuess(int max_number_to_guess)
    {
        _max_number_to_guess = max_number_to_guess;
    }

    public bool isTerminal()
    {
        return _player_won;
    }
}