using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Exercise 4: Lists
        // Name: Bamisile Damilare

        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter numbers one at a time. Enter 0 to finish.");

        // Collect numbers
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }

        } while (input != 0);

        // Calculate sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Calculate average
        double average = numbers.Count > 0 ? (double)sum / numbers.Count : 0;

        // Find largest number
        int largest = numbers.Count > 0 ? numbers[0] : 0;
        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }

        // Display results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}