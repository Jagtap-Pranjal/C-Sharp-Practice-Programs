using System;
public class Student
{
    string name = "Abc";
    int roll=1;
    public void fun1()
    {
    Console.WriteLine("Name of Student:"+name);
    Console.WriteLine("Roll no of Student: "+roll);
    }
 }
public class Marks:Student
{
    int sub1=90;
    int sub2=89;
    int sub3=78;
    public void fun2()
    {
        Console.WriteLine("Marks of sub1:"+sub1);
        Console.WriteLine("Marks of sub2:"+sub2);
        Console.WriteLine("Marks of sub3:"+sub3);

    }
}
public class Courses:Marks
{
    string c1="C#";
    string c2="ReactJs";
    string c3="AngularJs";
    public void fun3()
    {
        Console.WriteLine("Course 1:"+c1);
        Console.WriteLine("Course 2:"+c2);
        Console.WriteLine("Course 3:"+c3);
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Courses obj=new Courses();
        obj.fun1();
        obj.fun2();
        obj.fun3();
    }
}