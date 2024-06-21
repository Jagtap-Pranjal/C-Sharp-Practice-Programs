using System;

class Program
{
    static void Main()
    {
        string[] names = { "Abc", "Xyz", "Pqr", "Ijk", "Lmn" };

        Array.Sort(names);

        Console.WriteLine("Sorted names:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}
