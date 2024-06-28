using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int size = int.Parse(Console.ReadLine());

        // Create an array with the specified size
        int[] numbers = new int[size];

        // Prompt the user to enter each element
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Reverse the array
        Array.Reverse(numbers);

        // Print the elements of the reversed array
        Console.WriteLine("Reversed array elements:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
