using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Student
{
    class Student
    {
        Int32 id;
        string firstName;
        string lastName;

        public int M1;

        private int M2;
        private int M3;

        public void setStudentData(Int32 ids, string fname, string lname)
        {
            id = ids;
            firstName = fname;
            lastName = lname;
        }
        public void setMarks(Int32 M1, Int32 M2, Int32 M3)
        {
            this.M1 = M1;
            this.M2 = M2;
            this.M3 = M3;
        }
        public Int32 setTotal()
        {
            Int32 total;
            total = M1 + M2 + M3;
            return total;
        }

        public void getStudentData()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("First Name : " + firstName);
            Console.WriteLine("Last Name : " + lastName);
            Console.WriteLine("Full Name :" + firstName + " " + lastName);
            Console.WriteLine("Marks_1 : " + M1);
            Console.WriteLine("Marks_2 : " + M2);
            Console.WriteLine("Marks_3 : " + M3);
            Int32 Total = setTotal();
            Console.WriteLine("Total Marks for this student : " + Total);
        }
    }
}
