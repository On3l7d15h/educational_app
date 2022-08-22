namespace WindowsFormsAppEducationalApp1.Forms
{
    partial class FormMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMembers));
            this.pnl_student_sec = new System.Windows.Forms.Panel();
            this.pib_student = new System.Windows.Forms.PictureBox();
            this.lbl_students = new System.Windows.Forms.Label();
            this.lbl_maintitle = new System.Windows.Forms.Label();
            this.lbl_professors = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_subjects = new System.Windows.Forms.Panel();
            this.pnl_student_sec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_subjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_student_sec
            // 
            this.pnl_student_sec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            this.pnl_student_sec.Controls.Add(this.pib_student);
            this.pnl_student_sec.Controls.Add(this.lbl_students);
            this.pnl_student_sec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_student_sec.Location = new System.Drawing.Point(82, 118);
            this.pnl_student_sec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_student_sec.Name = "pnl_student_sec";
            this.pnl_student_sec.Size = new System.Drawing.Size(314, 205);
            this.pnl_student_sec.TabIndex = 7;
            this.pnl_student_sec.Click += new System.EventHandler(this.pnl_student_sec_Click);
            this.pnl_student_sec.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_student_sec_Paint);
            // 
            // pib_student
            // 
            this.pib_student.BackColor = System.Drawing.Color.Transparent;
            this.pib_student.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pib_student.BackgroundImage")));
            this.pib_student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pib_student.Enabled = false;
            this.pib_student.Location = new System.Drawing.Point(26, 38);
            this.pib_student.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pib_student.Name = "pib_student";
            this.pib_student.Size = new System.Drawing.Size(124, 128);
            this.pib_student.TabIndex = 10;
            this.pib_student.TabStop = false;
            // 
            // lbl_students
            // 
            this.lbl_students.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_students.AutoSize = true;
            this.lbl_students.BackColor = System.Drawing.Color.Transparent;
            this.lbl_students.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_students.ForeColor = System.Drawing.Color.White;
            this.lbl_students.Location = new System.Drawing.Point(195, 83);
            this.lbl_students.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_students.Name = "lbl_students";
            this.lbl_students.Size = new System.Drawing.Size(103, 30);
            this.lbl_students.TabIndex = 9;
            this.lbl_students.Text = "Students";
            // 
            // lbl_maintitle
            // 
            this.lbl_maintitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_maintitle.AutoSize = true;
            this.lbl_maintitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_maintitle.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maintitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            this.lbl_maintitle.Location = new System.Drawing.Point(386, 15);
            this.lbl_maintitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_maintitle.Name = "lbl_maintitle";
            this.lbl_maintitle.Size = new System.Drawing.Size(111, 30);
            this.lbl_maintitle.TabIndex = 6;
            this.lbl_maintitle.Text = "Members";
            // 
            // lbl_professors
            // 
            this.lbl_professors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_professors.AutoSize = true;
            this.lbl_professors.BackColor = System.Drawing.Color.Transparent;
            this.lbl_professors.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_professors.ForeColor = System.Drawing.Color.White;
            this.lbl_professors.Location = new System.Drawing.Point(195, 83);
            this.lbl_professors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_professors.Name = "lbl_professors";
            this.lbl_professors.Size = new System.Drawing.Size(99, 30);
            this.lbl_professors.TabIndex = 10;
            this.lbl_professors.Text = "Subjects";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(26, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 128);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_subjects
            // 
            this.pnl_subjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            this.pnl_subjects.Controls.Add(this.pictureBox1);
            this.pnl_subjects.Controls.Add(this.lbl_professors);
            this.pnl_subjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_subjects.Location = new System.Drawing.Point(484, 118);
            this.pnl_subjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_subjects.Name = "pnl_subjects";
            this.pnl_subjects.Size = new System.Drawing.Size(314, 205);
            this.pnl_subjects.TabIndex = 8;
            this.pnl_subjects.Click += new System.EventHandler(this.panel2_Click);
            // 
            // FormMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 510);
            this.Controls.Add(this.pnl_subjects);
            this.Controls.Add(this.pnl_student_sec);
            this.Controls.Add(this.lbl_maintitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMembers";
            this.Text = "FormMembers";
            this.pnl_student_sec.ResumeLayout(false);
            this.pnl_student_sec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_subjects.ResumeLayout(false);
            this.pnl_subjects.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_student_sec;
        private System.Windows.Forms.Label lbl_maintitle;
        private System.Windows.Forms.Label lbl_students;
        private System.Windows.Forms.PictureBox pib_student;
        private System.Windows.Forms.Label lbl_professors;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_subjects;
    }
}