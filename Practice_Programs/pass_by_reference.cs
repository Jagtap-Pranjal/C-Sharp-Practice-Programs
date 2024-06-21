using System;

class Program
{
    static void Main()
    {
        int number = 5;
        Console.WriteLine("Before call: " + number);
        PassByReference(ref number);
        Console.WriteLine("After call: " + number);
    }

    static void PassByReference(ref int num)
    {
        num = 10;
        Console.WriteLine("Inside method: " + num);
    }
}
