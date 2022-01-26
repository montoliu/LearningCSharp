namespace GuessANumber;

public class Player
{
    public Player()
    { }

    public Action Think(GameState gs)
    {
        List<Action> listActions = gs.GetAllPossibleActions();
        
        Console.WriteLine("List of possible actions to be played:");
        for (int i=1; i<=listActions.Count; i++)
            Console.WriteLine("Action " + i + " -> " + listActions[i-1].ToString());
        Console.WriteLine("Select the action to be played:");
        String s = Console.ReadLine(); 
        return listActions[Convert.ToInt16(s)-1];   // C# vector are 0 to n-1
    }
}