using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose the value you want to calculate:");
        Console.WriteLine("1. Distance");
        Console.WriteLine("2. Speed");
        Console.WriteLine("3. Time");
        Console.Write("Enter your choice (1-3): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CalculateDistance();
                break;
            case 2:
                CalculateSpeed();
                break;
            case 3:
                CalculateTime();
                break;
            default:
                Console.WriteLine("Invalid choice, please restart the program and choose 1, 2, or 3.");
                break;
        }
    }

    static void CalculateDistance()
    {
        Console.Write("Enter Speed (in meters per second): ");
        double speed = double.Parse(Console.ReadLine());

        Console.Write("Enter Time (in seconds): ");
        double time = double.Parse(Console.ReadLine());

        double distance = speed * time;
        Console.WriteLine("Distance = Speed * Time = " + speed + " * " + time + " = " + distance + " meters");
    }

    static void CalculateSpeed()
    {
        Console.Write("Enter Distance (in meters): ");
        double distance = double.Parse(Console.ReadLine());

        Console.Write("Enter Time (in seconds): ");
        double time = double.Parse(Console.ReadLine());

        double speed = distance / time;
        Console.WriteLine("Speed = Distance / Time = " + distance + " / " + time + " = " + speed + " meters per second");
    }

    static void CalculateTime()
    {
        Console.Write("Enter Distance (in meters): ");
        double distance = double.Parse(Console.ReadLine());

        Console.Write("Enter Speed (in meters per second): ");
        double speed = double.Parse(Console.ReadLine());

        double time = distance / speed;
        Console.WriteLine("Time = Distance / Speed = " + distance + " / " + speed + " = " + time + " seconds");
    }
}
