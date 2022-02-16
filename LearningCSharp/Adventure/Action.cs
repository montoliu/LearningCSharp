namespace Adventure;

public class Action
{
    private string _direction;

    public Action(string direction)
    {
        _direction = direction;
    }

    public string GetDirection()
    {
        return _direction;
    }
    
    public bool IsU()
    {
        return _direction == "U";
    }
    public bool IsR()
    {
        return _direction == "R";
    }
    public bool IsD()
    {
        return _direction == "D";
    }
    public bool IsL()
    {
        return _direction == "L";
    }

    public override string ToString()
    {
        return _direction;
    }
}