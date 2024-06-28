using System;

class ArrayOperations
{
    // Function to insert an element at a specified index
    static int[] InsertElement(int[] arr, int element, int index)
    {
        if (index < 0 || index > arr.Length)
        {
            Console.WriteLine("Invalid index");
            return arr;
        }

        int[] newArr = new int[arr.Length + 1];
        for (int i = 0, j = 0; i < newArr.Length; i++)
        {
            if (i == index)
            {
                newArr[i] = element;
            }
            else
            {
                newArr[i] = arr[j];
                j++;
            }
        }
        return newArr;
    }

    // Function to update an element at a specified index
    static void UpdateElement(int[] arr, int element, int index)
    {
        if (index < 0 || index >= arr.Length)
        {
            Console.WriteLine("Invalid index");
            return;
        }

        arr[index] = element;
    }

    // Function to delete an element at a specified index
    static int[] DeleteElement(int[] arr, int index)
    {
        if (index < 0 || index >= arr.Length)
        {
            Console.WriteLine("Invalid index");
            return arr;
        }

        int[] newArr = new int[arr.Length - 1];
        for (int i = 0, j = 0; i < arr.Length; i++)
        {
            if (i == index)
                continue;
            newArr[j] = arr[i];
            j++;
        }
        return newArr;
    }

    // Function to print the array
    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // Main function to test the operations with switch case
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        bool continueOperations = true;

        while (continueOperations)
        {
            Console.WriteLine("\nArray operations:");
            Console.WriteLine("1. Insert an element");
            Console.WriteLine("2. Update an element");
            Console.WriteLine("3. Delete an element");
            Console.WriteLine("4. Print array");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the element to insert: ");
                    int insertElement = int.Parse(Console.ReadLine());
                    Console.Write("Enter the index to insert at: ");
                    int insertIndex = int.Parse(Console.ReadLine());
                    arr = InsertElement(arr, insertElement, insertIndex);
                    Console.WriteLine("Array after insertion:");
                    PrintArray(arr);
                    break;
                case 2:
                    Console.Write("Enter the new element: ");
                    int updateElement = int.Parse(Console.ReadLine());
                    Console.Write("Enter the index to update: ");
                    int updateIndex = int.Parse(Console.ReadLine());
                    UpdateElement(arr, updateElement, updateIndex);
                    Console.WriteLine("Array after update:");
                    PrintArray(arr);
                    break;
                case 3:
                    Console.Write("Enter the index to delete: ");
                    int deleteIndex = int.Parse(Console.ReadLine());
                    arr = DeleteElement(arr, deleteIndex);
                    Console.WriteLine("Array after deletion:");
                    PrintArray(arr);
                    break;
                case 4:
                    Console.WriteLine("Current array:");
                    PrintArray(arr);
                    break;
                case 5:
                    continueOperations = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

