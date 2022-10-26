using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Marks
{
    public partial class Student_marks : Form
    {
        Marks mar;

        int m1=0;
        int m2=0;
        int m3=0;
        Int32 tot;
        double avg;
        public Student_marks()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void total_Click(object sender, EventArgs e)
        {
            setStudent_Click(sender, e);
            if (String.IsNullOrEmpty(txtMarks1.Text))
            {
                MessageBox.Show("Please enter a Marks1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMarks1.Focus();
                txtMarks1.BackColor = Color.Red;
                return;
            }
            else if (String.IsNullOrEmpty(txtMarks2.Text))
            {
                MessageBox.Show("Please enter a Marks2", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMarks2.Focus();
                txtMarks2.BackColor = Color.Red;
                return;
            }
            else if (String.IsNullOrEmpty(txtMarks3.Text))
            {
                MessageBox.Show("Please enter a Marks3", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMarks3.Focus();
                txtMarks3.BackColor = Color.Red;
                return;
            }
            
            if(!int.TryParse(txtMarks1.Text,out m1))
            {
                MessageBox.Show("Please enter a number value", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMarks1.Focus();
                txtMarks1.BackColor = Color.Red;
                return;
            }else if (!int.TryParse(txtMarks2.Text, out m2))
            {
                MessageBox.Show("Please enter a number value", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMarks2.Focus();
                txtMarks2.BackColor = Color.Red;
                return;
            }else if (!int.TryParse(txtMarks3.Text, out m3))
            {
                MessageBox.Show("Please enter a number value", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMarks3.Focus();
                txtMarks3.BackColor = Color.Red;
                return;
            }
            this.mar = new Marks();

            this.m1 = Convert.ToInt32(txtMarks1.Text);
            this.m2 = Convert.ToInt32(txtMarks2.Text);
            this.m3 = Convert.ToInt32(txtMarks3.Text);
            this.mar.setMarks(this.m1,this.m2,this.m3);
            this.tot = this.mar.setTotal();
            MessageBox.Show(this.tot.ToString(),"Total");
        }

        private void average_Click(object sender, EventArgs e)
        {
           total_Click(sender, e);
            this.avg = this.mar.average(this.tot); 
           MessageBox.Show(this.avg.ToString(),"Average");
        }

        private void setStudent_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ids.Text))
            {
                MessageBox.Show("Please enter Your ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ids.Focus();
                ids.BackColor = Color.Red;
                return;
            }
            else if (String.IsNullOrEmpty(firstname.Text))
            {
                MessageBox.Show("Please enter Your FirstName", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                firstname.Focus();
                firstname.BackColor = Color.Red;
                return;
            }
            else if (String.IsNullOrEmpty(lastname.Text))
            {
                MessageBox.Show("Please enter Your LastName", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lastname.Focus();
                lastname.BackColor = Color.Red;
                return;
            }
            this.mar = new Marks();
            this.mar.setStudentData(Convert.ToInt32(ids.Text),firstname.Text,lastname.Text);
            //MessageBox.Show(Convert.ToString(this.mar.id),"ID",MessageBoxButtons.OK);
            //MessageBox.Show(this.mar.firstname,"FirstName",MessageBoxButtons.OK);
            //MessageBox.Show(this.mar.lastname, "LastName", MessageBoxButtons.OK);
            MessageBox.Show(("ID : " + Convert.ToString(this.mar.id)) +("\nFirstName : "+ this.mar.firstname) + ("\nLastName : "+this.mar.lastname),"Student_Information",MessageBoxButtons.OK);
        }
    }
}
