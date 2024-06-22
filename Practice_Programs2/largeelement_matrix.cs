using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 5, 3, 9 },
            { 1, 4, 7 },
            { 2, 6, 8 }
        };

        int largest = matrix[0, 0];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > largest)
                {
                    largest = matrix[i, j];
                }
            }
        }

        Console.WriteLine("The largest element in the matrix is: " + largest);
    }
}
