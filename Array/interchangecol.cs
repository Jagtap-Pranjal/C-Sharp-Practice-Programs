using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("Original Matrix:");
        DisplayMatrix(matrix);

        // Ask user for columns to interchange
        Console.Write("\nEnter the index of the first column (0-based): ");
        int col1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the index of the second column (0-based): ");
        int col2 = int.Parse(Console.ReadLine());

        // Validate column indices
        if (col1 < 0 || col1 >= matrix.GetLength(1) || col2 < 0 || col2 >= matrix.GetLength(1))
        {
            Console.WriteLine("Invalid column indices.");
            return;
        }

        // Interchange columns
        InterchangeColumns(matrix, col1, col2);

        Console.WriteLine("\nMatrix after interchanging columns:");
        DisplayMatrix(matrix);
    }

    static void InterchangeColumns(int[,] matrix, int col1, int col2)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            // Swap elements in each row at columns col1 and col2
            int temp = matrix[i, col1];
            matrix[i, col1] = matrix[i, col2];
            matrix[i, col2] = temp;
        }
    }

    static void DisplayMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
