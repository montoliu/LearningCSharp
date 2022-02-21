namespace GamePlatform;

public class AdventureGameState: iGameState
{
    private int _state;

    public List<Action> GetAllPossibleActions()
    {
        List<Action> l = new List<Action>();
        AdventureAction up = new AdventureAction("U");
        AdventureAction right = new AdventureAction("R");
        AdventureAction down = new AdventureAction("D");
        AdventureAction left = new AdventureAction("L");

        switch (_state)
        {
            case 0:
            case 4:
            case 13:
            case 21:
                l.Add(up);
                l.Add(right);
                l.Add(down);
                break;
            case 2:
            case 8:
            case 20:
                l.Add(up);
                l.Add(right);
                l.Add(down);
                l.Add(left);
                break;
            case 3:
                l.Add(down);
                l.Add(left);
                break;
            case 5:
            case 11:
            case 14:
                l.Add(up);
                l.Add(right);
                l.Add(left);
                break;
            case 6:
            case 16:
            case 12:
            case 10:
                l.Add(up);
                l.Add(down);
                l.Add(left);
                break;
            case 7:
            case 9:
                l.Add(right);
                l.Add(down);
                break;
            case 15:
            case 18:
                l.Add(right);
                l.Add(down);
                l.Add(left);
                break;
            case 17:
            case 19:
                l.Add(up);
                l.Add(right);
                break;
        }

        return l;
    }

    public void Reset()
    {
        _state = 0;
    }

    public bool IsTerminal()
    {
        return _state == 1 || _state == -1;
    }
    
    
    public override string ToString()
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
                str = "Text state 0 (URD)";
                break;
            case 2: 
                str = "Text state 2 (URDL)";
                break;
            case 3:
                str = "Text state 3 (DL)";
                break;
            case 4: 
                str = "Text state 4 (URD)";
                break;
            case 5:
                str = "Text state 5 (URL)";
                break;
            case 6:
                str = "Text state 6 (UDL)";
                break;
            case 7:
                str = "Text state 7 (RD)";
                break;
            case 8:
                str = "Text state 8 (URDL)";
                break;
            case 9:
                str = "Text state 9 (RD)";
                break;
            case 10: 
                str = "Text state 10 (UDL)";
                break;
            case 11:
                str = "Text state 11 (URL)";
                break;
            case 12: 
                str = "Text state 12 (UDL)";
                break;
            case 13: 
                str = "Text state 13 (URD)";
                break;
            case 14:
                str = "Text state 14 (UPL)";
                break;
            case 15:
                str = "Text state 15 (RDL)";
                break;
            case 16: 
                str = "Text state 16 (UDL)";
                break;
            case 17:
                str = "Text state 17 (UR)";
                break;
            case 18:
                str = "Text state 18 (RDL)";
                break;
            case 19:
                str = "Text state 19 (UR)";
                break;
            case 20:
                str = "Text state 20 (URDL)";
                break;
            case 21:
                str = "Text state 21 (URD)";
                break;
        }

        return str;
    }
    
    public int GetState()
    {
        return _state; 
    }

    public void SetState(int state)
    {
        _state = state;
    }
}