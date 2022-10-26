using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWork
{
    internal class Marks : Student
    {
        public void setMarks(int m1, int m2, int m3)
        {
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }
        public Int32 setTotal()
        {
            int total = this.m1 + this.m2 + this.m3;

            return total;
        }
        public double average(int total)
        {
            double avg = total / 3.0;
            return avg;
        }

        public void displayData()
        {
            base.displayData();
            Console.WriteLine("Marks_1 : " + m1);
            Console.WriteLine("Marks_2 : " + m2);
            Console.WriteLine("Marks_3 : " + m3);
            Int32 Total = setTotal();
            Console.WriteLine("Total Marks for this student : " + Total);
            Double Avg = average(Total);
            Console.WriteLine("Average for this student : " + Avg);
        }

       
    }
}
