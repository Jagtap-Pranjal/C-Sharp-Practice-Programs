using System;
class program
{
    public static void Main()
    {
        int length, width, area;
        Console.Write ("Enter length of room in feet: ");
        length = Convert.ToInt32 (Console.ReadLine());
        Console.Write ( "Enter width of room in feet:");
        width = Convert.ToInt32(Console.ReadLine());
        area = length * width;
        Console.WriteLine ("Floor is " + area +  " square feet.");
        Console.ReadLine();
    }
}