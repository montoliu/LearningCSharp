namespace TicTacToe;

public class Action
{
    private int _place;
    public Action(int place)
    {
        _place = place;
    }

    public int GetPlace()
    {
        return _place;
    }
    
    public override string ToString()
    {
        return Convert.ToString(_place);
    }
}