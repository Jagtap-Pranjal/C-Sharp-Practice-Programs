using System;
public class Program{
    public static void Main(string[] args)
    {
        float area,l,r;
        int n;
        Console.WriteLine("Enter the num of sides:");
        n=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the length:");
        l=Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Enter the radius:");
        r=Convert.ToInt32(Console.ReadLine());

        area=(n/2)*l*r;

        Console.WriteLine("Area is :"+area);
    }
}
