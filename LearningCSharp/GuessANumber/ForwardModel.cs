namespace GuessANumber;

public class ForwardModel
{
    public ForwardModel()
    { }

    public int Play(GameState gameState, Action action)
    {
        int guess = action.GetNumber();
        int c = gameState.CompareWithTheNumber(guess);  // 0 is the number, -1 smaller, 1 greater
        if (c == 0)
            gameState.PlayerWon();
        else
            gameState.IncrementTries();

        return c;
    }
}