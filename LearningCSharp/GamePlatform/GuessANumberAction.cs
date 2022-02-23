namespace GamePlatform;

public class GuessANumberAction: Action
{
    private int _number;        // The number that the player think that it is the correct one

    public GuessANumberAction(int number)
    {
        _number = number;
    }

    public int GetNumber()                              
    {
        return _number;
    }

    public override string ToString()
    {
        return Convert.ToString("Number: " + _number);
    }
}