namespace GuessANumber;

class GuessANumber
{
    static void Main(String[] args)
    {
        int    max_number_to_guess = 100;
        int    max_iterations      = 10;
        Game   game                = new Game(max_number_to_guess, max_iterations);
        Player player              = new Player();
        
        game.Run(player);
    }
}

