namespace GuessANumber;

public class Action
{
    private int _number;

    public Action(int number)
    {
        _number = number;
    }

    public int GetNumber() max_number_to_guess = 100;                                      
    {
        return _number;
    }

    public String ToString()
    {
        return Convert.ToString(_number);
    }
}