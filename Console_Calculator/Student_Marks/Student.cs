using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Marks
{
    class Student
    {
        public Int32 id;
        public string firstname;
        public string lastname;
        

       
        public void setStudentData(Int32 id, string firstname, string lastname)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
        }
        public void displayData()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("First Name : " + firstname);
            Console.WriteLine("Last Name : " + lastname);
            Console.WriteLine("Full Name :" + firstname + " " + lastname);
        }
       
    }
}

