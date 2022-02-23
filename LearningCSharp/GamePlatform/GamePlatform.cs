namespace GamePlatform;

public class GamePlatform
{
    static void Main(String[] args)
    {
        AdventureGame adventureGame = new AdventureGame();
        GuessANumberGame guessANumberGame = new GuessANumberGame();
        guessANumberGame.SetMaxNumberToGuess(10);
        guessANumberGame.SetMaxTries(5);
        
        HumanPlayer humanPlayer = new HumanPlayer();
        RandomPlayer randomPlayer = new RandomPlayer();
        
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("-     Adventure Game Human Player      -");
        Console.WriteLine("----------------------------------------");
        adventureGame.Run(humanPlayer);
        Console.WriteLine("\n");
        
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("-     Adventure Game Random Player     -");
        Console.WriteLine("----------------------------------------");
        adventureGame.Run(randomPlayer);  
        Console.WriteLine("\n");
        
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("-   Guess a Number Game Human Player   -");
        Console.WriteLine("----------------------------------------");
        guessANumberGame.Run(humanPlayer);
        Console.WriteLine("\n");

        Console.WriteLine("----------------------------------------");
        Console.WriteLine(" -  Guess a Number Game Random Player  -");
        Console.WriteLine("----------------------------------------");
        guessANumberGame.Run(randomPlayer);
        Console.WriteLine("\n");
    }
}