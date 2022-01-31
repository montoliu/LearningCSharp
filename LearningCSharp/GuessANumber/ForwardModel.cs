namespace GuessANumber;

// Implements the rules of the game
public class ForwardModel
{
    public ForwardModel()
    { }

    // Plays the action given the actual state of the game
    // Updates the state (after playing the ation)
    // Returns 1 if the hidden number is greater, -1 if it is smaller and 0 if it is equal
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