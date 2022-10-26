using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_Student
{
    public partial class Add_student : Form
    {
        Student stu;
        
        Int32 M1;
        Int32 M2;
        Int32 M3;
        Int32 total;
        //double avg;
        public Add_student()
        {
            InitializeComponent();
        }

        private void Add_student_Load(object sender, EventArgs e)
        {

        }

        private void tot_Click(object sender, EventArgs e)
        {
            this.stu = new Student();
            this.M1 = Convert.ToInt32(marks1.Text);
            this.M2 = Convert.ToInt32(marks2.Text);
            this.M3 = Convert.ToInt32(marks3.Text);
            stu.setMarks(this.M1, this.M2, this.M3);
            this.total = this.stu.setTotal();

        }
    }

}
