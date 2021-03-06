namespace GamePlatform;

public class AdventureAction: Action
{
    private string _position;     // "U", "R", "D" or "L"

    public AdventureAction(string position)
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