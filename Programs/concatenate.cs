using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter the first string
        Console.Write("Enter the first string: ");
        string firstString = Console.ReadLine();

        // Prompt the user to enter the second string
        Console.Write("Enter the second string: ");
        string secondString = Console.ReadLine();

        // Concatenate the strings
        string concatenatedString = firstString + secondString;

        // Display the result
        Console.WriteLine("Concatenated string: " + concatenatedString);
    }
}
