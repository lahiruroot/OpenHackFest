using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Marks objMarks = new Marks();//
            Console.WriteLine("Enter Your ID : ");
            string id = Console.ReadLine();
            Console.WriteLine("Enter First Name : ");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            string lname = Console.ReadLine();
            //s1 = new Student(Convert.ToInt32(id), fname, lname);
            Console.WriteLine("Student Marks_1 : ");
            string M1 = Console.ReadLine();
            Console.WriteLine("Student Marks_2 : ");
            string M2 = Console.ReadLine();
            Console.WriteLine("Student Marks_3 : ");
            string M3 = Console.ReadLine();
            Console.WriteLine("------------------------------");
            objMarks.setStudentData(Convert.ToInt32(id),fname,lname);
            objMarks.setMarks(Convert.ToInt32(M1), Convert.ToInt32(M2), Convert.ToInt32(M3));
            objMarks.setTotal();
            objMarks.displayData();
            Console.ReadLine();
        }
    }
}
