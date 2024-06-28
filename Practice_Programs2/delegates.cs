// C# program to illustrate the use of Delegates
using System;

namespace Program
{
    class D
    {
        // Declaring delegates to represent methods that take two integers and return void
        public delegate void BinaryOperationDelegate(int a, int b);

        // Method to add two numbers
        public void Add(int a, int b)
        {
            Console.WriteLine("({0} + {1}) = {2}", a, b, a + b);
        }

        // Method to subtract two numbers
        public void Subtract(int a, int b)
        {
            Console.WriteLine("({0} - {1}) = {2}", a, b, a - b);
        }

        // Main Method
        public static void Main(String[] args)
        {
            // Create an instance of the class
            D obj = new D();

            // Create delegates to represent the Add and Subtract methods
            BinaryOperationDelegate addDelegate = new BinaryOperationDelegate(obj.Add);
            BinaryOperationDelegate subtractDelegate = new BinaryOperationDelegate(obj.Subtract);

            // Invoke the delegates with arguments
            addDelegate(100, 40);
            subtractDelegate(100, 60);

            // Alternatively, you can use the Invoke method to call the delegates
            // addDelegate.Invoke(100, 40);
            // subtractDelegate.Invoke(100, 60);
        }
    }
}