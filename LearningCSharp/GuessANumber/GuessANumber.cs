namespace GuessANumber;

class GuessANumber
{
    // Main function
    static void Main(String[] args)
    {
        int    max_number_to_guess = 10;   // The player must guess a number between 1 and this value
        int    max_tries           = 5;    // Maximum number of tries for the player
        
        Game   game                = new Game(max_number_to_guess, max_tries);  // Create the game
        Player player              = new Player();                              // Create the player
        
        game.Run(player);   // Run the game played by the player
    }
}

