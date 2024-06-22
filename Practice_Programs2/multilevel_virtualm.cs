using System;

// Base class
class Vehicle
{
    protected string brand;
    protected string model;
    protected int year;

    // Constructor
    public Vehicle(string brand, string model, int year)
    {
        this.brand = brand;
        this.model = model;
        this.year = year;
    }

    // Virtual method to display vehicle information
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Year: " + year);
    }
}

// Derived class
class Car : Vehicle
{
    protected int doors;

    // Constructor
    public Car(string brand, string model, int year, int doors)
        : base(brand, model, year)
    {
        this.doors = doors;
    }

    // Override method to display car information
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Doors: " + doors);
    }
}

// Further derived class (multilevel inheritance)
class ElectricCar : Car
{
    protected double batteryCapacity;

    // Constructor
    public ElectricCar(string brand, string model, int year, int doors, double batteryCapacity)
        : base(brand, model, year, doors)
    {
        this.batteryCapacity = batteryCapacity;
    }

    // Override method to display electric car information
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Battery Capacity: " + batteryCapacity + " kWh");
    }
}

class Program
{
    static void Main()
    {
        Vehicle vehicle1 = new Vehicle("Toyota", "Camry", 2022);
        Car car1 = new Car("Ford", "Mustang", 2021, 2);
        ElectricCar eCar1 = new ElectricCar("Tesla", "Model S", 2023, 4, 100);

        Console.WriteLine("Vehicle:");
        vehicle1.DisplayInfo();
        Console.WriteLine();

        Console.WriteLine("Car:");
        car1.DisplayInfo();
        Console.WriteLine();

        Console.WriteLine("Electric Car:");
        eCar1.DisplayInfo();
    }
}
