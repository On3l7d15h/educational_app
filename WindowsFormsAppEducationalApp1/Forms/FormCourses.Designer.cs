namespace WindowsFormsAppEducationalApp1.Forms
{
    partial class FormCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCourses));
            this.lbl_maintitle = new System.Windows.Forms.Label();
            this.pib_courses = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pib_courses)).BeginInit();
            this.SuspendLayout();
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
            this.lbl_maintitle.Location = new System.Drawing.Point(375, 22);
            this.lbl_maintitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_maintitle.Name = "lbl_maintitle";
            this.lbl_maintitle.Size = new System.Drawing.Size(152, 30);
            this.lbl_maintitle.TabIndex = 3;
            this.lbl_maintitle.Text = "Your Courses";
            // 
            // pib_courses
            // 
            this.pib_courses.BackColor = System.Drawing.SystemColors.Control;
            this.pib_courses.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pib_courses.BackgroundImage")));
            this.pib_courses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pib_courses.Location = new System.Drawing.Point(244, 61);
            this.pib_courses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pib_courses.Name = "pib_courses";
            this.pib_courses.Size = new System.Drawing.Size(404, 427);
            this.pib_courses.TabIndex = 6;
            this.pib_courses.TabStop = false;
            this.pib_courses.Click += new System.EventHandler(this.pib_courses_Click);
            // 
            // FormCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 510);
            this.Controls.Add(this.pib_courses);
            this.Controls.Add(this.lbl_maintitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCourses";
            this.Text = "FormCourses";
            ((System.ComponentModel.ISupportInitialize)(this.pib_courses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_maintitle;
        private System.Windows.Forms.PictureBox pib_courses;
    }
}