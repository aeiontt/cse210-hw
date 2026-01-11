using System;

class Program
{
    static void Main(string[] args)
    {
        // Exercise 2: Conditionals
        // Name: Bamisile Damilare

        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();

        int grade;

        // Validate input
        if (!int.TryParse(input, out grade))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            return;
        }

        string letterGrade;

        // Determine letter grade
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        // Display result
        Console.WriteLine($"Your letter grade is: {letterGrade}");

        // Pass or fail message
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep trying! You can do better next time.");
        }
    }
}