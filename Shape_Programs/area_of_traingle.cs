using System;  
class main  
{   static void Main()   
    {  
      float  b ,h ;  
      Console.WriteLine("Enter h : " );
      h=Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter your b : " );
      b=Convert.ToInt32(Console.ReadLine());
      
      // double area =  (b*h) / 2 ; 
      double area =  0.5*b*h;   
      Console.WriteLine("Area of Triangle is :"+area);  
    }}  