using System;

class Program
{
    // Function that receives two int numbers and returns their sum
    static int Add(int num1, int num2)
    {
        return num1 + num2; // Returns the sum of the two numbers
    }

    static void Main()
    {
        // Asks the user for two numbers
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());

        // Calls the Add function and store the result
        int result = Add(number1, number2);

        // Displays the result of the addition
        Console.WriteLine($"The sum of {number1} and {number2} is: {result}");
    }
}