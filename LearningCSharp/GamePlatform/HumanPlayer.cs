namespace GamePlatform;

public class HumanPlayer : iPlayer
{
    public Action Think(iGameState gs)
    {
        // Get all the possible actions to be played
        List<Action> listActions = gs.GetAllPossibleActions();
        
        Console.WriteLine("List of possible actions to be played:");
        int i = 0;
        foreach (var action in listActions)
        {
            Console.WriteLine("Action " + i + " -> " + action.ToString());
            i += 1;
        }
        
        // Ask to the  user by the number of action to be played
        Console.WriteLine("Select the action to be played:");
        string s = Console.ReadLine(); 
        return listActions[Convert.ToInt16(s)]; 
    }
}