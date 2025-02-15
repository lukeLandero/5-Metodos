using System;

class Program
{
    // Function that receives an integer and determines if it is even or odd
    static void CheckEvenOdd(int number)
    {
        // We use the modulo operator (%) to check if the number is even or odd
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is an even number.");
        }
        else
        {
            Console.WriteLine($"{number} is an odd number.");
        }
    }

    static void Main()
    {
        // Asks the user to enter a number
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        // Calls the function to check if the number is even or odd
        CheckEvenOdd(number);
    }
}