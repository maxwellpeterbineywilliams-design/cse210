using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random generator = new Random();
        int randomNumber = generator.Next(1, 101);
        Console.WriteLine($"The random number is: {randomNumber}");

        int userGuess = 0;
        int attempts = 0;

        while (userGuess != randomNumber)
        {
            Console.Write("what is your guess?");
            string userInput = Console.ReadLine();
            userGuess = int.Parse(userInput);
            attempts++;

            if (userGuess < randomNumber)
            {
                    Console.WriteLine("Higher");
            }
            else if (userGuess > randomNumber)
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
