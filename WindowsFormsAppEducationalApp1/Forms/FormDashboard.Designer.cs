namespace WindowsFormsAppEducationalApp1.Forms
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.pnl_subjects = new System.Windows.Forms.Panel();
            this.pib_special = new System.Windows.Forms.PictureBox();
            this.lbl_special = new System.Windows.Forms.Label();
            this.pnl_professors = new System.Windows.Forms.Panel();
            this.pib_professors_sec = new System.Windows.Forms.PictureBox();
            this.lbl_professors = new System.Windows.Forms.Label();
            this.pnl_students = new System.Windows.Forms.Panel();
            this.pib_student = new System.Windows.Forms.PictureBox();
            this.lbl_students = new System.Windows.Forms.Label();
            this.lbl_maintitle = new System.Windows.Forms.Label();
            this.pnl_subjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_special)).BeginInit();
            this.pnl_professors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_professors_sec)).BeginInit();
            this.pnl_students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_student)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_subjects
            // 
            this.pnl_subjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            this.pnl_subjects.Controls.Add(this.pib_special);
            this.pnl_subjects.Controls.Add(this.lbl_special);
            this.pnl_subjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_subjects.Location = new System.Drawing.Point(405, 356);
            this.pnl_subjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_subjects.Name = "pnl_subjects";
            this.pnl_subjects.Size = new System.Drawing.Size(365, 223);
            this.pnl_subjects.TabIndex = 9;
            this.pnl_subjects.Click += new System.EventHandler(this.pnl_subjects_Click);
            this.pnl_subjects.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_subjects_Paint);
            // 
            // pib_special
            // 
            this.pib_special.BackColor = System.Drawing.Color.Transparent;
            this.pib_special.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pib_special.BackgroundImage")));
            this.pib_special.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pib_special.Enabled = false;
            this.pib_special.Location = new System.Drawing.Point(13, 36);
            this.pib_special.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pib_special.Name = "pib_special";
            this.pib_special.Size = new System.Drawing.Size(165, 158);
            this.pib_special.TabIndex = 16;
            this.pib_special.TabStop = false;
            // 
            // lbl_special
            // 
            this.lbl_special.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_special.AutoSize = true;
            this.lbl_special.BackColor = System.Drawing.Color.Transparent;
            this.lbl_special.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_special.ForeColor = System.Drawing.Color.White;
            this.lbl_special.Location = new System.Drawing.Point(243, 95);
            this.lbl_special.Name = "lbl_special";
            this.lbl_special.Size = new System.Drawing.Size(111, 38);
            this.lbl_special.TabIndex = 15;
            this.lbl_special.Text = "Special";
            // 
            // pnl_professors
            // 
            this.pnl_professors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            this.pnl_professors.Controls.Add(this.pib_professors_sec);
            this.pnl_professors.Controls.Add(this.lbl_professors);
            this.pnl_professors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_professors.Location = new System.Drawing.Point(593, 121);
            this.pnl_professors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_professors.Name = "pnl_professors";
            this.pnl_professors.Size = new System.Drawing.Size(365, 218);
            this.pnl_professors.TabIndex = 8;
            this.pnl_professors.Click += new System.EventHandler(this.pnl_professors_Click);
            this.pnl_professors.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_professors_Paint);
            // 
            // pib_professors_sec
            // 
            this.pib_professors_sec.BackColor = System.Drawing.Color.Transparent;
            this.pib_professors_sec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pib_professors_sec.BackgroundImage")));
            this.pib_professors_sec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pib_professors_sec.Enabled = false;
            this.pib_professors_sec.Location = new System.Drawing.Point(17, 31);
            this.pib_professors_sec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pib_professors_sec.Name = "pib_professors_sec";
            this.pib_professors_sec.Size = new System.Drawing.Size(165, 158);
            this.pib_professors_sec.TabIndex = 14;
            this.pib_professors_sec.TabStop = false;
            this.pib_professors_sec.Click += new System.EventHandler(this.pib_professors_sec_Click);
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
            this.lbl_professors.Location = new System.Drawing.Point(197, 95);
            this.lbl_professors.Name = "lbl_professors";
            this.lbl_professors.Size = new System.Drawing.Size(154, 38);
            this.lbl_professors.TabIndex = 13;
            this.lbl_professors.Text = "Professors";
            this.lbl_professors.Click += new System.EventHandler(this.lbl_professors_Click);
            // 
            // pnl_students
            // 
            this.pnl_students.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            this.pnl_students.Controls.Add(this.pib_student);
            this.pnl_students.Controls.Add(this.lbl_students);
            this.pnl_students.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_students.Location = new System.Drawing.Point(207, 121);
            this.pnl_students.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_students.Name = "pnl_students";
            this.pnl_students.Size = new System.Drawing.Size(365, 218);
            this.pnl_students.TabIndex = 7;
            this.pnl_students.Click += new System.EventHandler(this.pnl_students_Click);
            this.pnl_students.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_students_Paint);
            // 
            // pib_student
            // 
            this.pib_student.BackColor = System.Drawing.Color.Transparent;
            this.pib_student.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pib_student.BackgroundImage")));
            this.pib_student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pib_student.Enabled = false;
            this.pib_student.Location = new System.Drawing.Point(19, 31);
            this.pib_student.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pib_student.Name = "pib_student";
            this.pib_student.Size = new System.Drawing.Size(165, 158);
            this.pib_student.TabIndex = 12;
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
            this.lbl_students.Location = new System.Drawing.Point(217, 95);
            this.lbl_students.Name = "lbl_students";
            this.lbl_students.Size = new System.Drawing.Size(135, 38);
            this.lbl_students.TabIndex = 11;
            this.lbl_students.Text = "Students";
            this.lbl_students.Click += new System.EventHandler(this.lbl_students_Click);
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
            this.lbl_maintitle.Location = new System.Drawing.Point(511, 52);
            this.lbl_maintitle.Name = "lbl_maintitle";
            this.lbl_maintitle.Size = new System.Drawing.Size(142, 38);
            this.lbl_maintitle.TabIndex = 11;
            this.lbl_maintitle.Text = "Members";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 628);
            this.Controls.Add(this.lbl_maintitle);
            this.Controls.Add(this.pnl_subjects);
            this.Controls.Add(this.pnl_professors);
            this.Controls.Add(this.pnl_students);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.pnl_subjects.ResumeLayout(false);
            this.pnl_subjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_special)).EndInit();
            this.pnl_professors.ResumeLayout(false);
            this.pnl_professors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_professors_sec)).EndInit();
            this.pnl_students.ResumeLayout(false);
            this.pnl_students.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_subjects;
        private System.Windows.Forms.Panel pnl_professors;
        private System.Windows.Forms.Panel pnl_students;
        private System.Windows.Forms.Label lbl_maintitle;
        private System.Windows.Forms.PictureBox pib_student;
        private System.Windows.Forms.Label lbl_students;
        private System.Windows.Forms.PictureBox pib_special;
        private System.Windows.Forms.Label lbl_special;
        private System.Windows.Forms.PictureBox pib_professors_sec;
        private System.Windows.Forms.Label lbl_professors;
    }
}