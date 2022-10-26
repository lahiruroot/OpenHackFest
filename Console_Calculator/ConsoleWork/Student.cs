using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWork
{
    class Student
    {
        Int32 id;
        string firstName;
        string lastName;
        public int m1;
        public int m2;
        public int m3;
        public double avg;

        public void setStudentData(int id,string fname,string lname)
        {
            this.id =id;
            this.firstName =fname;
            this.lastName = lname;
        }
        public void displayData()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("First Name : " + firstName);
            Console.WriteLine("Last Name : " + lastName);
            Console.WriteLine("Full Name :" + firstName + " " + lastName);
        }
    }
}
