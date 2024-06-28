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

        // Ask user for rows to interchange
        Console.Write("\nEnter the index of the first row (0-based): ");
        int row1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the index of the second row (0-based): ");
        int row2 = int.Parse(Console.ReadLine());

        // Validate row indices
        if (row1 < 0 || row1 >= matrix.GetLength(0) || row2 < 0 || row2 >= matrix.GetLength(0))
        {
            Console.WriteLine("Invalid row indices.");
            return;
        }

        // Interchange rows
        InterchangeRows(matrix, row1, row2);

        Console.WriteLine("\nMatrix after interchanging rows:");
        DisplayMatrix(matrix);
    }

    static void InterchangeRows(int[,] matrix, int row1, int row2)
    {
        int cols = matrix.GetLength(1);

        for (int j = 0; j < cols; j++)
        {
            // Swap elements in each column at rows row1 and row2
            int temp = matrix[row1, j];
            matrix[row1, j] = matrix[row2, j];
            matrix[row2, j] = temp;
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
