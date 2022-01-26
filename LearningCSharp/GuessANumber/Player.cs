namespace GuessANumber;

public class Player
{
    public Player()
    { }

    public Action Think(GameState gs)
    {
        List<Action> listActions = gs.GetAllPossibleActions();
        
        Console.WriteLine("List of possible actions to be played:");
        int i = 1;
        foreach (var action in listActions)
        {
            Console.WriteLine("Action " + i + " -> " + action.ToString());
            i += 1;
        }
        
        Console.WriteLine("Select the action to be played:");
        String s = Console.ReadLine(); 
        return listActions[Convert.ToInt16(s)-1];   // C# vectors are 0 to n-1
    }
}