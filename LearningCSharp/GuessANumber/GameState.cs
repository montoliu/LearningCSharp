namespace GuessANumber;

public class GameState
{
    private int  _maxNumberToGuess;
    private int  _maxTries;

    private int  _numberToGuess;
    private int  _try;
    private bool _playerWon;
    public GameState()
    {
        _maxNumberToGuess = 100;
        _maxTries = 10;
        
        _playerWon = false;
        _try  = 1;
    }
    
    // Getters and Setters
    public int GetMaxNumberToGuess()
    {
        return _maxNumberToGuess;
    }
    
    public int GetMaxTries()
    {
        return _maxTries;
    }

    public int GetTry()
    {
        return _try;
    }

    public int GetRemainingTries()
    {
        return _maxTries - _try + 1;
    }
    
    public void SetMaxNumberToGuess(int maxNumberToGuess)
    {
        _maxNumberToGuess = maxNumberToGuess;
    }

    public void SetMaxTries(int maxTries)
    {
        _maxTries = maxTries;
    }    

    // Return the list of all possible actions to be played
    public List<Action> GetAllPossibleActions()
    {
        List<Action> l = new List<Action>();

        for (int i = 1; i <= _maxNumberToGuess; i++)
        {
            Action action = new Action(i);
            l.Add(action);
        }

        return l;
    }

    public void Reset()
    {
        Random random = new Random();
        _numberToGuess = random.Next(_maxNumberToGuess) + 1;
        _playerWon = false;
        _try  = 1;
    }

    // Return true if the player won of if the max number of tries has been reached
    public bool IsTerminal()
    {
        return _playerWon || _try > _maxTries;
    }

    public int CompareWithTheNumber(int guess)
    {
        if (_numberToGuess < guess)
            return -1;
        if (_numberToGuess > guess)
            return 1;
        return 0;
    }

    public void IncrementTries()
    {
        _try += 1;
    }

    public void PlayerWon()
    {
        _playerWon = true;
    }

    public bool IsPlayerWon()
    {
        return _playerWon;
    }
}