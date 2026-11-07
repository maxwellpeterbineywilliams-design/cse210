
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // Generate a random magic number between 1 and 100
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int userGuess = -1;
        int attempts = 0;

        // Keep asking until the user guesses correctly
        while (userGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            userGuess = int.Parse(userInput);

            attempts++;

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed it!");
            }
        }

        Console.WriteLine($"It took you {attempts} attempts to guess the number.");
    }
}
