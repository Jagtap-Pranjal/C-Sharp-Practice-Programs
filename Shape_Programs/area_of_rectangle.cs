using System;
public class Program{
    public static void Main(string[] args)
    {
        float area,h,b;
        Console.WriteLine("Enter the h :");
        h=Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Enter the b :");
        b=Convert.ToInt32(Console.ReadLine());

        area=b*h;

        Console.WriteLine("Area is :"+area);
    }
}
