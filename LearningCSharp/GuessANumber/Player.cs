namespace GuessANumber;

public class Player
{
    public Player()
    { }

    // Given an state of the game, return the action to be played
    public Action Think(GameState gs)
    {
        // Get all the possible actions to be played
        List<Action> listActions = gs.GetAllPossibleActions();
        
        Console.WriteLine("List of possible actions to be played:");
        int i = 1;
        foreach (var action in listActions)
        {
            Console.WriteLine("Action " + i + " -> " + action.ToString());
            i += 1;
        }
        
        // Ask to the  user by the number of action to be played
        Console.WriteLine("Select the action to be played:");
        string s = Console.ReadLine(); 
        return listActions[Convert.ToInt16(s)-1];   // C# vectors are 0 to n-1
    }
}