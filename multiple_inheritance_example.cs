using System;

namespace MultipleInheritanceExample
{
    interface IA
    {
        void MethodA();
    }

    interface IB
    {
        void MethodB();
    }

    public class C : IA, IB
    {
        int btech_marks=95;
        int btech_rollno=1;
        public void MethodA()
        {
            int ssc_marks=90;
            int ssc_rollno=1;
            Console.WriteLine("------------SSC DETAILS------------");
            Console.WriteLine("SSC Rollno:"+ssc_rollno);
            Console.WriteLine("SSC Marks:"+ssc_marks);
            
        }

        public void MethodB()
        {
            int diploma_marks=80;
            int diploma_rollno=1;
            Console.WriteLine("------------DIPLOMA DETAILS--------");
            Console.WriteLine("Diploma Rollno:"+diploma_rollno);
            Console.WriteLine("Dipoma Marks:"+diploma_marks);
        }

        public void MethodC()
        {
            Console.WriteLine("------------Btech DETAILS----------");
            Console.WriteLine("Btech Rollno:"+btech_rollno);
            Console.WriteLine("Btech Marks:"+btech_marks);
        }

        public static void Main(string[] args)
        {
            C obj = new C();
            obj.MethodA();
            obj.MethodB();
            obj.MethodC();
        }
    }
}
