using System;
public class Circle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter radius:");
        double r=Convert.ToDouble(Console.ReadLine());
        double area=Math.PI*r*r;
        Console.WriteLine("Area of Circle:"+area);
        
     }
}