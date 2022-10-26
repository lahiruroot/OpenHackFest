namespace Add_Student
{
    partial class Add_student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.avg = new System.Windows.Forms.Button();
            this.tot = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.Button();
            this.marks3 = new System.Windows.Forms.Label();
            this.marks2 = new System.Windows.Forms.Label();
            this.marks1 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // avg
            // 
            this.avg.Location = new System.Drawing.Point(438, 308);
            this.avg.Name = "avg";
            this.avg.Size = new System.Drawing.Size(75, 23);
            this.avg.TabIndex = 15;
            this.avg.Text = "Average";
            this.avg.UseVisualStyleBackColor = true;
            // 
            // tot
            // 
            this.tot.Location = new System.Drawing.Point(357, 308);
            this.tot.Name = "tot";
            this.tot.Size = new System.Drawing.Size(75, 23);
            this.tot.TabIndex = 16;
            this.tot.Text = "Total";
            this.tot.UseVisualStyleBackColor = true;
            this.tot.Click += new System.EventHandler(this.tot_Click);
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(276, 308);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(75, 23);
            this.Data.TabIndex = 17;
            this.Data.Text = "Get Data";
            this.Data.UseVisualStyleBackColor = true;
            // 
            // marks3
            // 
            this.marks3.AutoSize = true;
            this.marks3.Location = new System.Drawing.Point(273, 261);
            this.marks3.Name = "marks3";
            this.marks3.Size = new System.Drawing.Size(62, 17);
            this.marks3.TabIndex = 9;
            this.marks3.Text = "Marks_3";
            // 
            // marks2
            // 
            this.marks2.AutoSize = true;
            this.marks2.Location = new System.Drawing.Point(273, 231);
            this.marks2.Name = "marks2";
            this.marks2.Size = new System.Drawing.Size(62, 17);
            this.marks2.TabIndex = 10;
            this.marks2.Text = "Marks_2";
            // 
            // marks1
            // 
            this.marks1.AutoSize = true;
            this.marks1.Location = new System.Drawing.Point(273, 203);
            this.marks1.Name = "marks1";
            this.marks1.Size = new System.Drawing.Size(62, 17);
            this.marks1.TabIndex = 11;
            this.marks1.Text = "Marks_1";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(273, 175);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(80, 17);
            this.lname.TabIndex = 12;
            this.lname.Text = "Last_Name";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(273, 149);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(80, 17);
            this.fname.TabIndex = 13;
            this.fname.Text = "First_Name";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(273, 119);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(21, 17);
            this.id.TabIndex = 14;
            this.id.Text = "ID";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(397, 261);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(131, 22);
            this.textBox6.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(397, 233);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(131, 22);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(397, 205);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(131, 22);
            this.textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(397, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(397, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(397, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 22);
            this.textBox1.TabIndex = 8;
            // 
            // Add_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.avg);
            this.Controls.Add(this.tot);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.marks3);
            this.Controls.Add(this.marks2);
            this.Controls.Add(this.marks1);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.id);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Add_student";
            this.Text = "Add_Student";
            this.Load += new System.EventHandler(this.Add_student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button avg;
        private System.Windows.Forms.Button tot;
        private System.Windows.Forms.Button Data;
        private System.Windows.Forms.Label marks3;
        private System.Windows.Forms.Label marks2;
        private System.Windows.Forms.Label marks1;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

