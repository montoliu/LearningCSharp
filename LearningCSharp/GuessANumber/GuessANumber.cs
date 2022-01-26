namespace GuessANumber;

class GuessANumber
{
    static void Main(String[] args)
    {
        int    max_number_to_guess = 10;   // The player must guess a number between 1 and this value
        int    max_tries           = 3;    // Maximum number of tries for the player
        
        Game   game                = new Game(max_number_to_guess, max_tries);
        Player player              = new Player();
        
        game.Run(player);
    }
}

