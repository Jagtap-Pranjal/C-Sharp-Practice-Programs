using System;
class Program
{
        static public void Main()
    {

        // assigned int value
        int num = 88;
 
        // boxing
        object obj = num;
 
        // value of num to be change
        num = 100;
 
        System.Console.WriteLine
        ("Value - type value of num is : {0}", num);
        System.Console.WriteLine
        ("Object - type value of obj is : {0}", obj);
    }
}