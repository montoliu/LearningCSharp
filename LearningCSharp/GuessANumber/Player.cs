namespace GuessANumber;

public class Player
{
    public Player()
    { }

    public Action Think(GameState gs)
    {
        List<Action> l = gs.GetAllPossibleActions();
        
        Console.WriteLine("Select the action to be played:");
        for (int i=0; i<l.Count; i++)
            Console.WriteLine("Action " + i + " -> " + l[i].ToString());

        String s = Console.ReadLine();
        return l[Convert.ToInt16(s)];
    }
}