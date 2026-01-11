using System;

class Program
{
    static void Main(string[] args)
    {
        // Exercise 1: Variables, Input, and Output
        // Personalized for Bamisile Damilare

        // Prompt for first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(firstName))
        {
            firstName = "Damilare";
        }

        // Prompt for last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(lastName))
        {
            lastName = "Bamisile";
        }

        // Display the full name in the required format
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}