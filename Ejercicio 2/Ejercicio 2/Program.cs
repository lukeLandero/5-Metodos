using System;

class Program
{
    // Method that receives a string as a parameter and prints it in reverse
    static void PrintReverse(string text)
    {
        // Converts the string to a character array, reverses it, and displays it
        char[] array = text.ToCharArray();
        Array.Reverse(array);
        Console.WriteLine(new string(array)); // Converts the array back to a string and displays it
    }

    static void Main()
    {
        // Asks the user for a text
        Console.Write("Enter a text: ");
        string text = Console.ReadLine();

        // Calls the method to print the text in reverse
        PrintReverse(text);
    }
}