using System;

class Program
{
    static void Main(string[] args)
    {
        // Exercise 3: Loops
        // Name: Bamisile Damilare

        int number;
        int sum = 0;
        int count = 0;
        int largest = int.MinValue;

        Console.WriteLine("Enter a list of numbers. Type 0 to finish.");

        // Loop until user enters 0
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                sum += number;
                count++;

                if (number > largest)
                {
                    largest = number;
                }
            }

        } while (number != 0);

        // Display results
        Console.WriteLine($"The sum is: {sum}");

        if (count > 0)
        {
            double average = (double)sum / count;
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {largest}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}