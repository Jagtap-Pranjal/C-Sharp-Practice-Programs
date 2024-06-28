using System;

class InsertionSortExample
{
    static void Main(string[] args)
    {
        int[] array = { 12, 11, 13, 5, 6 };
        Console.WriteLine("Original array:");
        PrintArray(array);

        InsertionSort(array);

        Console.WriteLine("\nSorted array:");
        PrintArray(array);
    }

    static void InsertionSort(int[] array)
    {
        int n = array.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = array[i];
            int j = i - 1;

            // Move elements of array[0..i-1], that are greater than key,to one position ahead of their current position
            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }
            array[j + 1] = key;
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
