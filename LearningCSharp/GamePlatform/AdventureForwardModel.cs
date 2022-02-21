namespace GamePlatform;

public class AdventureForwardModel: iForwardModel
{
    public int Play(iGameState gs, Action a)
    {
        AdventureGameState ags = (AdventureGameState) gs;
        AdventureAction action = (AdventureAction) a;
         
        if      (ags.GetState() == 0 && action.IsU()) ags.SetState(6);
        else if (ags.GetState() == 0 && action.IsR()) ags.SetState(11);
        else if (ags.GetState() == 0 && action.IsD()) ags.SetState(16);
        
        else if (ags.GetState() == 2 && action.IsU()) ags.SetState(-1);
        else if (ags.GetState() == 2 && action.IsR()) ags.SetState(3);
        else if (ags.GetState() == 2 && action.IsD()) ags.SetState(4);
        else if (ags.GetState() == 2 && action.IsL()) ags.SetState(-1);

        else if (ags.GetState() == 3 && action.IsD()) ags.SetState(5);
        else if (ags.GetState() == 3 && action.IsL()) ags.SetState(2);

        else if (ags.GetState() == 4 && action.IsU()) ags.SetState(2);
        else if (ags.GetState() == 4 && action.IsR()) ags.SetState(5);
        else if (ags.GetState() == 4 && action.IsD()) ags.SetState(10);
        
        else if (ags.GetState() == 5 && action.IsU()) ags.SetState(3);
        else if (ags.GetState() == 5 && action.IsR()) ags.SetState(6);
        else if (ags.GetState() == 5 && action.IsL()) ags.SetState(4);

        else if (ags.GetState() == 6 && action.IsU()) ags.SetState(-1);
        else if (ags.GetState() == 6 && action.IsD()) ags.SetState(0);
        else if (ags.GetState() == 6 && action.IsL()) ags.SetState(5);

        else if (ags.GetState() == 7 && action.IsR()) ags.SetState(8);
        else if (ags.GetState() == 7 && action.IsD()) ags.SetState(11);
        
        else if (ags.GetState() == 8 && action.IsU()) ags.SetState(-1);
        else if (ags.GetState() == 8 && action.IsR()) ags.SetState(-1);
        else if (ags.GetState() == 8 && action.IsD()) ags.SetState(12);
        else if (ags.GetState() == 8 && action.IsL()) ags.SetState(7);

        else if (ags.GetState() == 9 && action.IsR()) ags.SetState(10);
        else if (ags.GetState() == 9 && action.IsD()) ags.SetState(13);

        else if (ags.GetState() == 10 && action.IsU()) ags.SetState(4);
        else if (ags.GetState() == 10 && action.IsD()) ags.SetState(14);
        else if (ags.GetState() == 10 && action.IsL()) ags.SetState(9);

        else if (ags.GetState() == 11 && action.IsU()) ags.SetState(7);
        else if (ags.GetState() == 11 && action.IsR()) ags.SetState(12);
        else if (ags.GetState() == 11 && action.IsL()) ags.SetState(0);

        else if (ags.GetState() == 12 && action.IsU()) ags.SetState(8);
        else if (ags.GetState() == 12 && action.IsD()) ags.SetState(17);
        else if (ags.GetState() == 12 && action.IsL()) ags.SetState(11);

        else if (ags.GetState() == 13 && action.IsU()) ags.SetState(9);
        else if (ags.GetState() == 13 && action.IsR()) ags.SetState(14);
        else if (ags.GetState() == 13 && action.IsD()) ags.SetState(-1);
        
        else if (ags.GetState() == 14 && action.IsU()) ags.SetState(10);
        else if (ags.GetState() == 14 && action.IsR()) ags.SetState(15);
        else if (ags.GetState() == 14 && action.IsL()) ags.SetState(13);

        else if (ags.GetState() == 15 && action.IsR()) ags.SetState(16);
        else if (ags.GetState() == 15 && action.IsD()) ags.SetState(19);
        else if (ags.GetState() == 15 && action.IsL()) ags.SetState(14);

        else if (ags.GetState() == 16 && action.IsU()) ags.SetState(0);
        else if (ags.GetState() == 16 && action.IsD()) ags.SetState(20);
        else if (ags.GetState() == 16 && action.IsL()) ags.SetState(15);

        else if (ags.GetState() == 17 && action.IsU()) ags.SetState(12);
        else if (ags.GetState() == 17 && action.IsR()) ags.SetState(18);

        else if (ags.GetState() == 18 && action.IsR()) ags.SetState(-1);
        else if (ags.GetState() == 18 && action.IsD()) ags.SetState(21);
        else if (ags.GetState() == 18 && action.IsL()) ags.SetState(17);

        else if (ags.GetState() == 19 && action.IsU()) ags.SetState(15);
        else if (ags.GetState() == 19 && action.IsR()) ags.SetState(20);
        
        else if (ags.GetState() == 20 && action.IsU()) ags.SetState(16);
        else if (ags.GetState() == 20 && action.IsR()) ags.SetState(-1);
        else if (ags.GetState() == 20 && action.IsD()) ags.SetState(-1);
        else if (ags.GetState() == 20 && action.IsL()) ags.SetState(19);

        else if (ags.GetState() == 21 && action.IsU()) ags.SetState(18);
        else if (ags.GetState() == 21 && action.IsR()) ags.SetState(1);
        else if (ags.GetState() == 21 && action.IsD()) ags.SetState(-1);

        if (ags.GetState() == 1)  return 1;
        if (ags.GetState() == -1) return -1;
        return 0;
    }
}