namespace Adventure;

public class GameState
{
    private int _state;

    public GameState()
    {
        _state = 0;
    }

    public int GetState()
    {
        return _state; 
    }

    public void SetState(int state)
    {
        _state = state;
    }

    public void Reset()
    {
        _state = 0;
    }

    public bool IsTerminal()
    {
        return _state == 1 || _state == -1;
    }
    public string GetMessage()
    {
        string str = "";
        switch (_state)
        {
            case 1:
                str = "Congrats";
                break;
            case -1:
                str = "You die!";
                break;
            case 0: 
                str = "URD";
                break;
            case 2: 
                str = "URDL";
                break;
            case 3:
                str = "DL";
                break;
            case 4: 
                str = "URD";
                break;
            case 5:
                str = "URL";
                break;
            case 6:
                str = "UDL";
                break;
            case 7:
                str = "RD";
                break;
            case 8:
                str = "URDL";
                break;
            case 9:
                str = "RD";
                break;
            case 10: 
                str = "UDL";
                break;
            case 11:
                str = "URL";
                break;
            case 12: 
                str = "UDL";
                break;
            case 13: 
                str = "URD";
                break;
            case 14:
                str = "UPL";
                break;
            case 15:
                str = "RDL";
                break;
            case 16: 
                str = "UDL";
                break;
            case 17:
                str = "UR";
                break;
            case 18:
                str = "RDL";
                break;
            case 19:
                str = "UR";
                break;
            case 20:
                str = "URDL";
                break;
            case 21:
                str = "URD";
                break;
        }

        return str;
    }

    public List<Action> GetAllPossibleActions()
    {
        List<Action> l = new List<Action>();
        Action up = new Action("U");
        Action right = new Action("R");
        Action down = new Action("D");
        Action left = new Action("L");

        switch (_state)
        {
            case 0: case 4: case 13: case 21:
                l.Add(up);
                l.Add(right);
                l.Add(down);
                break;
            case 2: case 8: case 20:
                l.Add(up);
                l.Add(right);
                l.Add(down);
                l.Add(left);
                break;
            case 3:
                l.Add(down);
                l.Add(left);
                break;
            case 5: case 11: case 14:
                l.Add(up);
                l.Add(right);
                l.Add(left);
                break;
            case 6: case 16: case 12: case 10:
                l.Add(up);
                l.Add(down);
                l.Add(left);
                break;
            case 7: case 9:
                l.Add(right);
                l.Add(down);
                break;
            case 15: case 18:
                l.Add(right);
                l.Add(down);
                l.Add(left);
                break;
            case 17: case 19:
                l.Add(up);
                l.Add(right);
                break;
        }
        
        return l;
    }
}