using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        {
            DisplayWelcomeMessage();
            
            string name = PromptUserName();
            int number = PromptUserNumber();
            int square = SquareNumber(number);
            DisplayResult(name, square);
        }

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
       {
            Console.WriteLine("Please enter your name:");
            String name = Console.ReadLine();
            return name;
        
                
        }

        static int  PromptUserNumber()
        {
                Console.WriteLine("Please enter your favorite number:");
                int number = int.Parse(Console.ReadLine());
                return number;
        }

        static int SquareNumber(int number)
        {
            return number * number;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"Hello, {name}! The square of your favorite number is {square}.");
        }
    }
}