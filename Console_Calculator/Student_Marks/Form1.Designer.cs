namespace Student_Marks
{
    partial class Student_marks
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
            this.ids = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.txtMarks1 = new System.Windows.Forms.TextBox();
            this.txtMarks2 = new System.Windows.Forms.TextBox();
            this.txtMarks3 = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.first = new System.Windows.Forms.Label();
            this.last = new System.Windows.Forms.Label();
            this.setStudent = new System.Windows.Forms.Button();
            this.M1 = new System.Windows.Forms.Label();
            this.M2 = new System.Windows.Forms.Label();
            this.M3 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Button();
            this.average = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ids
            // 
            this.ids.Location = new System.Drawing.Point(126, 50);
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(240, 22);
            this.ids.TabIndex = 0;
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(126, 78);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(240, 22);
            this.firstname.TabIndex = 1;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(126, 106);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(240, 22);
            this.lastname.TabIndex = 2;
            // 
            // txtMarks1
            // 
            this.txtMarks1.Location = new System.Drawing.Point(126, 134);
            this.txtMarks1.Name = "txtMarks1";
            this.txtMarks1.Size = new System.Drawing.Size(240, 22);
            this.txtMarks1.TabIndex = 3;
            // 
            // txtMarks2
            // 
            this.txtMarks2.Location = new System.Drawing.Point(126, 167);
            this.txtMarks2.Name = "txtMarks2";
            this.txtMarks2.Size = new System.Drawing.Size(240, 22);
            this.txtMarks2.TabIndex = 4;
            // 
            // txtMarks3
            // 
            this.txtMarks3.Location = new System.Drawing.Point(126, 195);
            this.txtMarks3.Name = "txtMarks3";
            this.txtMarks3.Size = new System.Drawing.Size(240, 22);
            this.txtMarks3.TabIndex = 5;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(22, 55);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(21, 17);
            this.id.TabIndex = 1;
            this.id.Text = "ID";
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Location = new System.Drawing.Point(22, 81);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(72, 17);
            this.first.TabIndex = 2;
            this.first.Text = "FirstName";
            // 
            // last
            // 
            this.last.AutoSize = true;
            this.last.Location = new System.Drawing.Point(22, 109);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(72, 17);
            this.last.TabIndex = 3;
            this.last.Text = "LastName";
            // 
            // setStudent
            // 
            this.setStudent.Location = new System.Drawing.Point(70, 259);
            this.setStudent.Name = "setStudent";
            this.setStudent.Size = new System.Drawing.Size(100, 23);
            this.setStudent.TabIndex = 8;
            this.setStudent.Text = "GetStudent";
            this.setStudent.UseVisualStyleBackColor = true;
            this.setStudent.Click += new System.EventHandler(this.setStudent_Click);
            // 
            // M1
            // 
            this.M1.AutoSize = true;
            this.M1.Location = new System.Drawing.Point(22, 139);
            this.M1.Name = "M1";
            this.M1.Size = new System.Drawing.Size(62, 17);
            this.M1.TabIndex = 3;
            this.M1.Text = "Marks_1";
            // 
            // M2
            // 
            this.M2.AutoSize = true;
            this.M2.Location = new System.Drawing.Point(22, 167);
            this.M2.Name = "M2";
            this.M2.Size = new System.Drawing.Size(62, 17);
            this.M2.TabIndex = 3;
            this.M2.Text = "Marks_2";
            // 
            // M3
            // 
            this.M3.AutoSize = true;
            this.M3.Location = new System.Drawing.Point(22, 195);
            this.M3.Name = "M3";
            this.M3.Size = new System.Drawing.Size(62, 17);
            this.M3.TabIndex = 3;
            this.M3.Text = "Marks_3";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(176, 259);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(75, 23);
            this.total.TabIndex = 6;
            this.total.Text = "Total";
            this.total.UseVisualStyleBackColor = true;
            this.total.Click += new System.EventHandler(this.total_Click);
            // 
            // average
            // 
            this.average.Location = new System.Drawing.Point(257, 259);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(75, 23);
            this.average.TabIndex = 7;
            this.average.Text = "Average";
            this.average.UseVisualStyleBackColor = true;
            this.average.Click += new System.EventHandler(this.average_Click);
            // 
            // Student_marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(427, 334);
            this.Controls.Add(this.average);
            this.Controls.Add(this.total);
            this.Controls.Add(this.setStudent);
            this.Controls.Add(this.M3);
            this.Controls.Add(this.M2);
            this.Controls.Add(this.M1);
            this.Controls.Add(this.last);
            this.Controls.Add(this.first);
            this.Controls.Add(this.id);
            this.Controls.Add(this.txtMarks3);
            this.Controls.Add(this.txtMarks2);
            this.Controls.Add(this.txtMarks1);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.ids);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Student_marks";
            this.Text = "Student_Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ids;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox txtMarks1;
        private System.Windows.Forms.TextBox txtMarks2;
        private System.Windows.Forms.TextBox txtMarks3;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label first;
        private System.Windows.Forms.Label last;
        private System.Windows.Forms.Button setStudent;
        private System.Windows.Forms.Label M1;
        private System.Windows.Forms.Label M2;
        private System.Windows.Forms.Label M3;
        private System.Windows.Forms.Button total;
        private System.Windows.Forms.Button average;
    }
}

