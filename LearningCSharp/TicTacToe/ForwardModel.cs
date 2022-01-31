namespace TicTacToe;

public class ForwardModel
{
    public ForwardModel()
    { }

    // play the action
    // update the game state
    public int Play(GameState gameState, Action action)
    {
        gameState.SetElement(action, gameState.GetTurn());
        
        // check winner
        int winner = CheckWinner(gameState);
        gameState.SetWinner(winner);    

        // next player turn
        gameState.NextTurn();
        return 1;
    }

    // return player id when there is a winner, 0 otherwise
    public int CheckWinner(GameState gameState)
    {
        if (gameState.GetElement(0) == gameState.GetElement(1) && gameState.GetElement(0) == gameState.GetElement(2))
            return gameState.GetElement(0);
        if (gameState.GetElement(3) == gameState.GetElement(4) && gameState.GetElement(3) == gameState.GetElement(5))
            return gameState.GetElement(3);
        if (gameState.GetElement(6) == gameState.GetElement(7) && gameState.GetElement(6) == gameState.GetElement(8))
            return gameState.GetElement(6);
        if (gameState.GetElement(0) == gameState.GetElement(3) && gameState.GetElement(0) == gameState.GetElement(6))
            return gameState.GetElement(0);
        if (gameState.GetElement(1) == gameState.GetElement(4) && gameState.GetElement(1) == gameState.GetElement(7))
            return gameState.GetElement(1);
        if (gameState.GetElement(2) == gameState.GetElement(5) && gameState.GetElement(2) == gameState.GetElement(8))
            return gameState.GetElement(2);
        if (gameState.GetElement(0) == gameState.GetElement(4) && gameState.GetElement(0) == gameState.GetElement(8))
            return gameState.GetElement(0);
        if (gameState.GetElement(2) == gameState.GetElement(4) && gameState.GetElement(2) == gameState.GetElement(6))
            return gameState.GetElement(2);

        return 0;
    }


}