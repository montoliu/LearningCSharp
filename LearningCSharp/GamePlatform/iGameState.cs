namespace GamePlatform;

public interface iGameState
{
    public List<Action> GetAllPossibleActions();
    public void Reset(); 
    public bool IsTerminal();
}