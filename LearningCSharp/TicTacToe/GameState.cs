namespace TicTacToe;

public class GameState
{
    private int[] _board;  // 1 for player 1, 2 for player 2, 0 for empty
    private int   _turn;
    private int   _winner; // 1 for player 1, 2 for player 2, 0 for no winner yet
    
    public GameState()
    {
        _board = new int[9];
        for (int i = 0; i < 9; i++)
            _board[i] = 0;
        _turn   = 1;
        _winner = 0;
    }

    public int GetTurn()
    {
        return _turn;
    }

    public int GetWinner()
    {
        return _winner;
    }

    public string BoardToStr()
    {
        string s = _board[0] + " " + _board[1] + " " + _board[2] + "\n";
        s += _board[3] + " " + _board[4] + " " + _board[5] + "\n";
        s += _board[6] + " " + _board[7] + " " + _board[8] + "\n";
        return s;
    }
    
    public void Reset(int firstPlayer)
    {
        for (int i = 0; i < 9; i++)
            _board[i] = 0;

        _turn   = firstPlayer;
        _winner = 0;
    }

    // Terminal is when no empty spaces or there is a winner
    public bool IsTerminal()
    {
        if (_winner != 0)           // There is a winner
            return true;
        
        for (int i = 0; i < 9; i++)  // There is at least one empty space
            if (_board[i] == 0)
                return false;
        return true;
    }

    public List<Action> GetAllPossibleActions()
    {
        List<Action> l = new List<Action>();

        for (int i = 0; i < 9; i++)
        {
            if (_board[i] == 0)
            {
                Action action = new Action(i);
                l.Add(action);
            }
        }

        return l;
    }

    public int GetElement(int place)
    {
        return _board[place];
    }
    
    public void SetElement(Action action, int playerId)
    {
        _board[action.GetPlace()] = playerId;
    }

    public void NextTurn()
    {
        if (_turn == 1)
            _turn = 2;
        else
            _turn = 1;
    }

    public void SetWinner(int winner)
    {
        _winner = winner;
    }
}