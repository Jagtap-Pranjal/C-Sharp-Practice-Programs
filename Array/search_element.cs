using System;

class Program
{
    static void Main()
    {
        // Get the size of the array from the user
        Console.Write("Enter the number of elements in the array: ");
        int size = int.Parse(Console.ReadLine());

        // Initialize the array
        int[] numbers = new int[size];

        // Get the array elements from the user
        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Get the element to search for from the user
        Console.Write("Enter the element to search for: ");
        int target = int.Parse(Console.ReadLine());

        // Search for the element
        int index = -1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                index = i;
                break;
            }
        }

        // Output the result
        if (index != -1)
        {
            Console.WriteLine("Element " + target + " found at position: " + (index + 1));
        }
        else
        {
            Console.WriteLine("Element " + target + " not found in the array.");
        }
    }
}
