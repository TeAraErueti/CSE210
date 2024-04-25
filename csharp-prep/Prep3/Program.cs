using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)

    {
        string userReply = "yes";

        while (userReply =="yes")
        {

            Console.WriteLine("Welcome to the Magic Number Game");
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int randomGuess = -1;
            int guessCount = 0;
        

                while (randomGuess != magicNumber)    

                {      
                    Console.Write("What is your guess between 1 & 100? ");
                    guessCount = guessCount + 1;
                    randomGuess = int.Parse(Console.ReadLine());

                    if (magicNumber > randomGuess)
                    {
                        Console.WriteLine("Higher");
                    }
        
                    else if (magicNumber < randomGuess)
                    {
                        Console.WriteLine("Lower");
                    }
            
                    else 
                    //At this point the user has guessed the magic number correctly.
                    {
                        Console.WriteLine("You guessed correctly!");
                        Console.WriteLine($"It took you {guessCount} guesses.");
                         
                    }              
                }
            Console.Write("Would you like to play the magic number game again (yes or no)?");
            userReply = Console.ReadLine();            
        } 
        
        Console.Write("Thank you for playing.");   
    }   
}