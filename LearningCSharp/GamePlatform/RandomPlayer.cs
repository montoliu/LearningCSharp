namespace GamePlatform;

public class RandomPlayer: iPlayer
{
    public Action Think(iGameState gs)
    {
        // Get all the possible actions to be played
        List<Action> listActions = gs.GetAllPossibleActions();
        Random rnd = new Random();
        int idx = rnd.Next(0, listActions.Count);
        return listActions[idx]; 
    }
}