using System;
class Vehicle
{
   public void fun1()
   {
    Console.WriteLine("Hello World from Vehicle class");
   }
}
class BMW:Vehicle
{
 public void fun2()
   {
    Console.WriteLine("Hello World from BMW class");
   }
}
class Program
{
    public static void Main(string[] args)
    {
        BMW obj= new BMW();
        obj.fun1();
        obj.fun2();

    }
}