namespace Adventure;

public class Action
{
    private string _position;

    public Action(string position)
    {
        _position = position;
    }
    
    public bool IsU()
    {
        return _position == "U";
    }
    public bool IsR()
    {
        return _position == "R";
    }
    public bool IsD()
    {
        return _position == "D";
    }
    public bool IsL()
    {
        return _position == "L";
    }

    public override string ToString()
    {
        return _position;
    }
}