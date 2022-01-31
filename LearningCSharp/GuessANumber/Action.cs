namespace GuessANumber;

public class Action
{
    private int _number;        // The number that the player think that it is the correct one

    public Action(int number)
    {
        _number = number;
    }

    public int GetNumber()                              
    {
        return _number;
    }

    public override String ToString()
    {
        return Convert.ToString(_number);
    }
}