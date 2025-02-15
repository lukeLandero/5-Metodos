using System;

class Program
{
    // Method that receives two parameters (base and height) and calculates the area of the rectangle
    static double RectangleArea(double rectangleBase, double height)
    {
        // Calculates the area of the rectangle (base * height)
        return rectangleBase * height;
    }

    static void Main()
    {
        // Asks the user to enter the base and height of the rectangle
        Console.Write("Enter the base of the rectangle: ");
        double rectangleBase = double.Parse(Console.ReadLine());

        Console.Write("Enter the height of the rectangle: ");
        double height = double.Parse(Console.ReadLine());

        // Calls the method to calculate the area
        double area = RectangleArea(rectangleBase, height);

        // Displays the result of the area
        Console.WriteLine($"The area of the rectangle is: {area} square units.");
    }
}