using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string gradeInput = Console.ReadLine();
        int gradePercentage = int.Parse(gradeInput);

        string letterGrade = "";
        string letterGradeSymbol = "";

        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        
        if ((gradePercentage % 10 >= 7) && letterGrade != "F")
        {
            letterGradeSymbol += "+";
            Console.WriteLine($"Your grade is {letterGrade}{letterGradeSymbol}.");
        }
        else if (gradePercentage % 10 <= 3 && letterGrade != "F")
        {
            letterGradeSymbol += "-";
            Console.WriteLine($"Your grade is {letterGrade}{letterGradeSymbol}.");
        }

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine($"Your grade is {letterGrade}.");
            Console.WriteLine("Sorry, you did not pass the course. Better luck next time!");
        }

        }
    }

    
