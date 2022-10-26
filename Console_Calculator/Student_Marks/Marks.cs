using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Marks
{
    class Marks:Student
    {
        public int M1;
        public int M2;
        public int M3;

        public void setMarks(int M1, int M2, int M3)
        {
            this.M1 = M1;
            this.M2 = M2;
            this.M3 = M3;
        }
        public Int32 setTotal()
        {
            int total;
            total = this.M1 + this.M2 + this.M3;
            return total;
        }

        public double average(int total)
        {
            double avg;
            avg = total / 3.0;
            return avg;
        }
        public void displayData()
        {
            Int32 Total = setTotal();
            Console.WriteLine("Total Marks for this student : " + Total);
            double Avg = average(Total);
            Console.WriteLine("Average for this student : " + Avg);
        }
    }
}
