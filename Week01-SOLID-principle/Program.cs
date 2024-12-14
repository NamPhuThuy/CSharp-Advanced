using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Prompt the user for the length of the rectangle
        Console.Write("Enter the length of the rectangle: ");
        string lengthInput = Console.ReadLine();

        // Prompt the user for the width of the rectangle
        Console.Write("Enter the width of the rectangle: ");
        string widthInput = Console.ReadLine();

        // Error handling: Check if the inputs are valid numbers
        if (double.TryParse(lengthInput, out double length) && double.TryParse(widthInput, out double width))
        {
            // Calculate the area
            double area = length * width;

            // Display the result
            Console.WriteLine($"The area of the rectangle is: {area}");
        }
        else
        {
            // Display an error message if the input is invalid
            Console.WriteLine("Invalid input. Please enter numeric values for length and width.");
        }

        // Keep the console window open until a key is pressed (optional)
        Console.ReadKey();
    }
}