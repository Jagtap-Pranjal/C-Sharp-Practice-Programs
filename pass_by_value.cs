using System;

class Program
{
    static void Main()
    {
        int number = 5;
        Console.WriteLine("Before call: " + number);
        PassByValue(number);
        Console.WriteLine("After call: " + number);
    }

    static void PassByValue(int num)
    {
        num = 10;
        Console.WriteLine("Inside method: " + num);
    }
}
