using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = CelsiusToFahrenheit(celsius);

        Console.WriteLine("Temperature in Fahrenheit:"+fahrenheit);
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        // Formula to convert Celsius to Fahrenheit: F = (C * 9/5) + 32
        double fahrenheit = (celsius * 9 / 5) + 32;
        return fahrenheit;
    }
}
