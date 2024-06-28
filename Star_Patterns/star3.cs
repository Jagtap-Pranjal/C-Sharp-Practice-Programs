using System;

class Program
{
    static void Main()
    {
        int n = 5; // Number of rows

        // Upper half including the middle row
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        // Lower half
        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
