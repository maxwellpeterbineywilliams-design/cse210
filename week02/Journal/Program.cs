using System;

class Program
{
        static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal journal = new Journal();

        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Welcome to the Journal Program!");

            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save entries to a file");
            Console.WriteLine("4. Load entries from a file");
            Console.WriteLine("5. Quit");

            Console.Write("what would you like to do ?");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Enter your response: ");

                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToString("yyyy-MM-dd");

                    Entry newEntry = new Entry();
                    newEntry._date = date;
                    newEntry._prompt = prompt;
                    newEntry._response = response;

                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry added successfully!");
                    break;


                case "2":
                    journal.Display();
                    break;

                case "3":
                    Console.Write("Enter the filename to save entries: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;


                case "4":

                    Console.Write("Enter the filename to load entries: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Thank you for using the Journal Program.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            
    }
    
  }
}     