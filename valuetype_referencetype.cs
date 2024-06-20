using System;

class Program
{
    static void Main()
    {
        // Demonstrating value type parameter
        int valueType = 10;
        Console.WriteLine("Before PassByValue call: " + valueType);
        PassByValue(valueType);
        Console.WriteLine("After PassByValue call: " + valueType);

        // Demonstrating reference type parameter
        int[] referenceType = { 10 };
        Console.WriteLine("Before PassByReference call: " + referenceType[0]);
        PassByReference(referenceType);
        Console.WriteLine("After PassByReference call: " + referenceType[0]);
    }

    // Method to demonstrate pass by value
    static void PassByValue(int number)
    {
        number = 20;
    }

    // Method to demonstrate pass by reference
    static void PassByReference(int[] numberArray)
    {
        numberArray[0] = 20;
    }
}
