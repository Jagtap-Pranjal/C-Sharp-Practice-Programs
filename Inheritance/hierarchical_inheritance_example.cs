using System;
public class Student
{
    string name="ABC";
    int roll=1;
    public void fun1()
    {
        Console.WriteLine("Name of Student:"+name);
        Console.WriteLine("Roll no of Student:"+roll);
    }

}
public class Course:Student
{
    string c1="C++";
    string c2="Java";
    public void fun2()
    {
        Console.WriteLine("Course 1:"+c1);
        Console.WriteLine("Course 2:"+c2);
    }
}
public class Sports:Student
{
  string a1="Volleyball";
  string a2="Football";
  public void fun3()
  {
  Console.WriteLine("Activity 1:"+a1);
  Console.WriteLine("Activity 2:"+a2);
  }
}
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("----------------Student Course Details-----------------");
        Course obj1=new Course();
        obj1.fun1();
        obj1.fun2();
        Console.WriteLine("----------------Student Sports Details-----------------");
        Sports obj2=new Sports();
        obj2.fun1();
        obj2.fun3();
    }
}