using System;

class Program
{
    static void Main(string[] args)
    {
        // Exercise 5: Functions
        // Name: Bamisile Damilare

        DisplayWelcome();

        string userName = GetUserName();
        int favoriteNumber = GetFavoriteNumber();
        int squaredNumber = SquareNumber(favoriteNumber);

        DisplayResult(userName, squaredNumber);
    }

    // Displays a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Prompts the user for their name
    static string GetUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            name = "Bamisile Damilare";
        }

        return name;
    }

    // Prompts the user for their favorite number
    static int GetFavoriteNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Squares the number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Displays the final result
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}