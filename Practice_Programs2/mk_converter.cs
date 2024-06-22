using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose the conversion you want to perform:");
        Console.WriteLine("1. Meters to Kilometers");
        Console.WriteLine("2. Kilometers to Meters");
        Console.Write("Enter your choice (1 or 2): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                ConvertMetersToKilometers();
                break;
            case 2:
                ConvertKilometersToMeters();
                break;
            default:
                Console.WriteLine("Invalid choice. Please restart the program and choose 1 or 2.");
                break;
        }
    }

    static void ConvertMetersToKilometers()
    {
        Console.Write("Enter distance in meters: ");
        double meters = double.Parse(Console.ReadLine());
        double kilometers = meters / 1000;
        Console.WriteLine(meters + " meters is equal to " + kilometers + " kilometers.");
    }

    static void ConvertKilometersToMeters()
    {
        Console.Write("Enter distance in kilometers: ");
        double kilometers = double.Parse(Console.ReadLine());
        double meters = kilometers * 1000;
        Console.WriteLine(kilometers + " kilometers is equal to " + meters + " meters.");
    }
}
