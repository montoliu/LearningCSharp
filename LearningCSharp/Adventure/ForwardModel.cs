namespace Adventure;

public class ForwardModel
{
    public ForwardModel()
    {}

    public int Play(GameState gs, Action action)
    {
        if      (gs.GetState() == 0 && action.IsU()) gs.SetState(6);
        else if (gs.GetState() == 0 && action.IsR()) gs.SetState(11);
        else if (gs.GetState() == 0 && action.IsD()) gs.SetState(16);
        
        else if (gs.GetState() == 2 && action.IsU()) gs.SetState(-1);
        else if (gs.GetState() == 2 && action.IsR()) gs.SetState(3);
        else if (gs.GetState() == 2 && action.IsD()) gs.SetState(4);
        else if (gs.GetState() == 2 && action.IsL()) gs.SetState(-1);

        else if (gs.GetState() == 3 && action.IsD()) gs.SetState(5);
        else if (gs.GetState() == 3 && action.IsL()) gs.SetState(2);

        else if (gs.GetState() == 4 && action.IsU()) gs.SetState(2);
        else if (gs.GetState() == 4 && action.IsR()) gs.SetState(5);
        else if (gs.GetState() == 4 && action.IsD()) gs.SetState(10);
        
        else if (gs.GetState() == 5 && action.IsU()) gs.SetState(3);
        else if (gs.GetState() == 5 && action.IsR()) gs.SetState(6);
        else if (gs.GetState() == 5 && action.IsL()) gs.SetState(4);

        else if (gs.GetState() == 6 && action.IsU()) gs.SetState(-1);
        else if (gs.GetState() == 6 && action.IsD()) gs.SetState(0);
        else if (gs.GetState() == 6 && action.IsL()) gs.SetState(5);

        else if (gs.GetState() == 7 && action.IsR()) gs.SetState(8);
        else if (gs.GetState() == 7 && action.IsD()) gs.SetState(11);
        
        else if (gs.GetState() == 8 && action.IsU()) gs.SetState(-1);
        else if (gs.GetState() == 8 && action.IsR()) gs.SetState(-1);
        else if (gs.GetState() == 8 && action.IsD()) gs.SetState(12);
        else if (gs.GetState() == 8 && action.IsL()) gs.SetState(7);

        else if (gs.GetState() == 9 && action.IsR()) gs.SetState(10);
        else if (gs.GetState() == 9 && action.IsD()) gs.SetState(13);

        else if (gs.GetState() == 10 && action.IsU()) gs.SetState(4);
        else if (gs.GetState() == 10 && action.IsD()) gs.SetState(14);
        else if (gs.GetState() == 10 && action.IsL()) gs.SetState(9);

        else if (gs.GetState() == 11 && action.IsU()) gs.SetState(7);
        else if (gs.GetState() == 11 && action.IsR()) gs.SetState(12);
        else if (gs.GetState() == 11 && action.IsL()) gs.SetState(0);

        else if (gs.GetState() == 12 && action.IsU()) gs.SetState(8);
        else if (gs.GetState() == 12 && action.IsD()) gs.SetState(17);
        else if (gs.GetState() == 12 && action.IsL()) gs.SetState(11);

        else if (gs.GetState() == 13 && action.IsU()) gs.SetState(9);
        else if (gs.GetState() == 13 && action.IsR()) gs.SetState(14);
        else if (gs.GetState() == 13 && action.IsD()) gs.SetState(-1);
        
        else if (gs.GetState() == 14 && action.IsU()) gs.SetState(10);
        else if (gs.GetState() == 14 && action.IsR()) gs.SetState(15);
        else if (gs.GetState() == 14 && action.IsL()) gs.SetState(13);

        else if (gs.GetState() == 15 && action.IsR()) gs.SetState(16);
        else if (gs.GetState() == 15 && action.IsD()) gs.SetState(19);
        else if (gs.GetState() == 15 && action.IsL()) gs.SetState(14);

        else if (gs.GetState() == 16 && action.IsU()) gs.SetState(0);
        else if (gs.GetState() == 16 && action.IsD()) gs.SetState(20);
        else if (gs.GetState() == 16 && action.IsL()) gs.SetState(15);

        else if (gs.GetState() == 17 && action.IsU()) gs.SetState(12);
        else if (gs.GetState() == 17 && action.IsR()) gs.SetState(18);

        else if (gs.GetState() == 18 && action.IsR()) gs.SetState(-1);
        else if (gs.GetState() == 18 && action.IsD()) gs.SetState(21);
        else if (gs.GetState() == 18 && action.IsL()) gs.SetState(17);

        else if (gs.GetState() == 19 && action.IsU()) gs.SetState(15);
        else if (gs.GetState() == 19 && action.IsR()) gs.SetState(20);
        
        else if (gs.GetState() == 20 && action.IsU()) gs.SetState(16);
        else if (gs.GetState() == 20 && action.IsR()) gs.SetState(-1);
        else if (gs.GetState() == 20 && action.IsD()) gs.SetState(-1);
        else if (gs.GetState() == 20 && action.IsL()) gs.SetState(19);

        else if (gs.GetState() == 21 && action.IsU()) gs.SetState(18);
        else if (gs.GetState() == 21 && action.IsR()) gs.SetState(1);
        else if (gs.GetState() == 21 && action.IsD()) gs.SetState(-1);

        if (gs.GetState() == 1)
            return 1;
        if (gs.GetState() == -1)
            return -1;
        return 0;
    }
}