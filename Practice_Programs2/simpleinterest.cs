using System;

namespace SimpleInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter rate of interest (in %): ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter time (in years): ");
            double time = Convert.ToDouble(Console.ReadLine());

            double simpleInterest = (principal * rate * time) / 100;
            double totalamount= principal + simpleInterest;

            Console.WriteLine("Simple Interest:"+simpleInterest);
            Console.WriteLine("Total Amount:"+totalamount);

        }
    }
}