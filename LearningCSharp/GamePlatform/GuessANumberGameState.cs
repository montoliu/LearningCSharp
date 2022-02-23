namespace GamePlatform;

public class GuessANumberGameState: iGameState
{
    private int  _maxNumberToGuess;
    private int  _maxTries;

    private int  _numberToGuess;  // This must be hidden for players
    private int  _try;
    private bool _playerWon;
    
    public GuessANumberGameState()
    {
        _maxNumberToGuess = 10;
        _maxTries = 5;
        
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

    // Returns the list of all possible actions to be played
    public List<Action> GetAllPossibleActions()
    {
        List<Action> l = new List<Action>();

        for (int i = 1; i <= _maxNumberToGuess; i++)
        {
            GuessANumberAction action = new GuessANumberAction(i);
            l.Add(action);
        }

        return l;
    }

    // Initialize the state
    public void Reset()
    {
        Random random = new Random();
        _numberToGuess = random.Next(_maxNumberToGuess) + 1;
        _playerWon = false;
        _try  = 1;
    }

    // Return true if the player won or if the max number of tries has been reached
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

    public override string ToString()
    {
        string str;

        if (_playerWon) str = "You guessed the number after " + (GetTry()-1) + " tries." + _numberToGuess;
        else str = "You didn't guess the number after " + (GetTry()-1) + " tries." + _numberToGuess;
        return str;
    }
    
    public string GetRewardInformation(int reward)
    {
        string str = "";
        if (reward == -1) 
            str = "You failed, the number is smaller. Number of remaining tries: " + GetRemainingTries();
        else if (reward == 1)
            str = "You failed, the number is greater. Number of remaining tries: " + GetRemainingTries();
        return str;
    }
}