using System;

class Program
{
    static void Main()
    {
        // Define the matrix (3x3 for simplicity)
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Display the original matrix
        Console.WriteLine("Original Matrix:");
        DisplayMatrix(matrix);

        // Calculate and display the transpose
        int[,] transpose = CalculateTranspose(matrix);
        Console.WriteLine("\nTranspose Matrix:");
        DisplayMatrix(transpose);
    }

    // Method to calculate the transpose of a matrix
    static int[,] CalculateTranspose(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Create a new matrix to store the transpose
        int[,] transpose = new int[cols, rows];

        // Compute the transpose
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transpose[j, i] = matrix[i, j];
            }
        }

        return transpose;
    }

    // Method to display a matrix
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
