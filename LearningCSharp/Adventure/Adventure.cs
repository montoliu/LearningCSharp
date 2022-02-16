namespace Adventure;

class Adventure
{
    // Main function
    static void Main(String[] args)
    {

        Game   game                = new Game();    // Create the game
        Player player              = new Player();  // Create the player
        
        game.Run(player);   // Run the game played by the player
    }
}