using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Student Name: ");
        string studentName = Console.ReadLine();

        Console.Write("Enter Roll Number: ");
        string rollNumber = Console.ReadLine();

        Console.Write("Enter Class: ");
        string studentClass = Console.ReadLine();

        Console.Write("Enter Marks for Mathematics: ");
        int mathMarks = int.Parse(Console.ReadLine());

        Console.Write("Enter Marks for Science: ");
        int scienceMarks = int.Parse(Console.ReadLine());

        Console.Write("Enter Marks for English: ");
        int englishMarks = int.Parse(Console.ReadLine());

        Console.Write("Enter Marks for History: ");
        int historyMarks = int.Parse(Console.ReadLine());

        Console.Write("Enter Marks for Geography: ");
        int geographyMarks = int.Parse(Console.ReadLine());

        int totalMarks = mathMarks + scienceMarks + englishMarks + historyMarks + geographyMarks;
        double averageMarks = totalMarks / 5.0;

        string grade = GetGrade(averageMarks);

        Console.WriteLine("\n===================================");
        Console.WriteLine("            MARKSHEET              ");
        Console.WriteLine("===================================\n");

        Console.WriteLine("Student Information:");
        Console.WriteLine("-------------------");
        Console.WriteLine("Name: " + studentName);
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Class: " + studentClass);

        Console.WriteLine("\nMarks Obtained:");
        Console.WriteLine("-------------------");
        Console.WriteLine("Mathematics: " + mathMarks);
        Console.WriteLine("Science: " + scienceMarks);
        Console.WriteLine("English: " + englishMarks);
        Console.WriteLine("History: " + historyMarks);
        Console.WriteLine("Geography: " + geographyMarks);

        Console.WriteLine("\nResult:");
        Console.WriteLine("-------------------");
        Console.WriteLine("Total Marks: " + totalMarks + " / 500");
        Console.WriteLine("Average Marks: " + averageMarks.ToString("F2"));
        Console.WriteLine("Grade: " + grade);

    }

    static string GetGrade(double averageMarks)
    {
        if (averageMarks >= 90)
        {
            return "A";
        }
        else if (averageMarks >= 80)
        {
            return "B";
        }
        else if (averageMarks >= 70)
        {
            return "C";
        }
        else if (averageMarks >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
}
