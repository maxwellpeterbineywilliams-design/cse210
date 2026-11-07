using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        int userNumber = -1;

        Console.WriteLine("please enter numbers, type 0 to finish");
        while (userNumber != 0)
        {
            Console.Write("ENTER A NUMBER: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        if (numbers.Count > 0)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            Console.WriteLine($"The sum is: {sum}");
            float average = (float)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");
        }
        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
            
    }
}