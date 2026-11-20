using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

    
        Reference reference = new Reference("John", 3, 16);

        Scripture scripture = new Scripture(
            reference,
            "For God so loved the world that he gave his only begotten Son"
        );

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to finish: ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}
    
