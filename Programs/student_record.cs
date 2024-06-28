using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of records you want to input:");
        int numberOfRecords = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <=numberOfRecords; i++)
        {
            string name, branch, college;
            int roll, sem;

            Console.WriteLine("\nEnter details for record " + i + ":");

            Console.WriteLine("Enter Rollno:");
            roll = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter Branch:");
            branch = Console.ReadLine();

            Console.WriteLine("Enter Sem:");
            sem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter College name:");
            college = Console.ReadLine();
            
            Console.WriteLine("-------------Student Record--------------");
           for(int j=i+1;j>i;j--)
            {
            Console.WriteLine("Rollno of Student :"+roll);
            Console.WriteLine("Name of Student :"+name);
            Console.WriteLine("Branch of Student :"+branch);
            Console.WriteLine("SEM  of Student :"+sem);
            Console.WriteLine("College name :"+college);
            }
        }
       
    }
}
