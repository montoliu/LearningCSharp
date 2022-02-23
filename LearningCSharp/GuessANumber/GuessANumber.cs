namespace GuessANumber;

class GuessANumber
{
    // Main function
    static void Main(String[] args)
    {
        int    maxNumberToGuess = 10;   // The player must guess a number between 1 and this value
        int    maxTries         = 5;    // Maximum number of tries for the player
        
        Game   game                = new Game();    // Create the game
        Player player              = new Player();  // Create the player

        game.SetMaxNumberToGuess(maxNumberToGuess);
        game.SetMaxTries(maxTries);
        
        game.Run(player);   // Run the game played by the player
    }
}

