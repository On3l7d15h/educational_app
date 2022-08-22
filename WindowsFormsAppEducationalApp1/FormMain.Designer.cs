namespace WindowsFormsAppEducationalApp1
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnl_topBar = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pnl_sideBar = new System.Windows.Forms.Panel();
            this.pnl_dashboard = new System.Windows.Forms.Panel();
            this.pib_dashboard = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_courses = new System.Windows.Forms.Panel();
            this.pib_courses = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_members = new System.Windows.Forms.Panel();
            this.pib_members = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.pib_login = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_start = new System.Windows.Forms.Panel();
            this.pib_home = new System.Windows.Forms.PictureBox();
            this.lbl_home = new System.Windows.Forms.Label();
            this.gdc_topBar = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnl_body = new System.Windows.Forms.Panel();
            this.pnl_topBar.SuspendLayout();
            this.pnl_sideBar.SuspendLayout();
            this.pnl_dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_dashboard)).BeginInit();
            this.pnl_courses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_courses)).BeginInit();
            this.pnl_members.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_members)).BeginInit();
            this.pnl_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_login)).BeginInit();
            this.pnl_start.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_home)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_topBar
            // 
            this.pnl_topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            this.pnl_topBar.Controls.Add(this.lbl_title);
            this.pnl_topBar.Controls.Add(this.btn_exit);
            this.pnl_topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_topBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_topBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_topBar.Name = "pnl_topBar";
            this.pnl_topBar.Size = new System.Drawing.Size(1292, 59);
            this.pnl_topBar.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(4, 10);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(238, 38);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Educational App";
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(1229, 7);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(59, 42);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pnl_sideBar
            // 
            this.pnl_sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(103)))));
            this.pnl_sideBar.Controls.Add(this.pnl_dashboard);
            this.pnl_sideBar.Controls.Add(this.pnl_courses);
            this.pnl_sideBar.Controls.Add(this.pnl_members);
            this.pnl_sideBar.Controls.Add(this.pnl_login);
            this.pnl_sideBar.Controls.Add(this.pnl_start);
            this.pnl_sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_sideBar.Location = new System.Drawing.Point(0, 59);
            this.pnl_sideBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_sideBar.Name = "pnl_sideBar";
            this.pnl_sideBar.Size = new System.Drawing.Size(92, 628);
            this.pnl_sideBar.TabIndex = 1;
            // 
            // pnl_dashboard
            // 
            this.pnl_dashboard.Controls.Add(this.pib_dashboard);
            this.pnl_dashboard.Controls.Add(this.label4);
            this.pnl_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_dashboard.Location = new System.Drawing.Point(0, 368);
            this.pnl_dashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_dashboard.Name = "pnl_dashboard";
            this.pnl_dashboard.Size = new System.Drawing.Size(92, 92);
            this.pnl_dashboard.TabIndex = 5;
            this.pnl_dashboard.Visible = false;
            this.pnl_dashboard.Click += new System.EventHandler(this.pnl_dashboard_Click);
            // 
            // pib_dashboard
            // 
            this.pib_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(103)))));
            this.pib_dashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pib_dashboard.BackgroundImage")));
            this.pib_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pib_dashboard.Enabled = false;
            this.pib_dashboard.Location = new System.Drawing.Point(21, 11);
            this.pib_dashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pib_dashboard.Name = "pib_dashboard";
            this.pib_dashboard.Size = new System.Drawing.Size(48, 49);
            this.pib_dashboard.TabIndex = 2;
            this.pib_dashboard.TabStop = false;
            this.pib_dashboard.Click += new System.EventHandler(this.pib_dashboard_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dashboard";
            // 
            // pnl_courses
            // 
            this.pnl_courses.Controls.Add(this.pib_courses);
            this.pnl_courses.Controls.Add(this.label3);
            this.pnl_courses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_courses.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_courses.Location = new System.Drawing.Point(0, 276);
            this.pnl_courses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_courses.Name = "pnl_courses";
            this.pnl_courses.Size = new System.Drawing.Size(92, 92);
            this.pnl_courses.TabIndex = 4;
            this.pnl_courses.Visible = false;
            this.pnl_courses.Click += new System.EventHandler(this.pnl_courses_Click);
            // 
            // pib_courses
            // 
            this.pib_courses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(103)))));
            this.pib_courses.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pib_courses.BackgroundImage")));
            this.pib_courses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pib_courses.Enabled = false;
            this.pib_courses.Location = new System.Drawing.Point(21, 11);
            this.pib_courses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pib_courses.Name = "pib_courses";
            this.pib_courses.Size = new System.Drawing.Size(48, 49);
            this.pib_courses.TabIndex = 2;
            this.pib_courses.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Courses";
            // 
            // pnl_members
            // 
            this.pnl_members.Controls.Add(this.pib_members);
            this.pnl_members.Controls.Add(this.label2);
            this.pnl_members.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_members.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_members.Location = new System.Drawing.Point(0, 184);
            this.pnl_members.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_members.Name = "pnl_members";
            this.pnl_members.Size = new System.Drawing.Size(92, 92);
            this.pnl_members.TabIndex = 3;
            this.pnl_members.Visible = false;
            this.pnl_members.Click += new System.EventHandler(this.pnl_members_Click);
            // 
            // pib_members
            // 
            this.pib_members.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(103)))));
            this.pib_members.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pib_members.BackgroundImage")));
            this.pib_members.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pib_members.Enabled = false;
            this.pib_members.Location = new System.Drawing.Point(21, 11);
            this.pib_members.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pib_members.Name = "pib_members";
            this.pib_members.Size = new System.Drawing.Size(48, 49);
            this.pib_members.TabIndex = 2;
            this.pib_members.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Members";
            // 
            // pnl_login
            // 
            this.pnl_login.Controls.Add(this.pib_login);
            this.pnl_login.Controls.Add(this.label1);
            this.pnl_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_login.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_login.Location = new System.Drawing.Point(0, 92);
            this.pnl_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(92, 92);
            this.pnl_login.TabIndex = 1;
            this.pnl_login.Click += new System.EventHandler(this.pnl_login_Click);
            // 
            // pib_login
            // 
            this.pib_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(103)))));
            this.pib_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pib_login.BackgroundImage")));
            this.pib_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pib_login.Enabled = false;
            this.pib_login.Location = new System.Drawing.Point(21, 11);
            this.pib_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pib_login.Name = "pib_login";
            this.pib_login.Size = new System.Drawing.Size(48, 48);
            this.pib_login.TabIndex = 2;
            this.pib_login.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // pnl_start
            // 
            this.pnl_start.Controls.Add(this.pib_home);
            this.pnl_start.Controls.Add(this.lbl_home);
            this.pnl_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_start.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_start.Location = new System.Drawing.Point(0, 0);
            this.pnl_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_start.Name = "pnl_start";
            this.pnl_start.Size = new System.Drawing.Size(92, 92);
            this.pnl_start.TabIndex = 0;
            this.pnl_start.Click += new System.EventHandler(this.pnl_start_Click);
            // 
            // pib_home
            // 
            this.pib_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(103)))));
            this.pib_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pib_home.BackgroundImage")));
            this.pib_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pib_home.Enabled = false;
            this.pib_home.Location = new System.Drawing.Point(23, 11);
            this.pib_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pib_home.Name = "pib_home";
            this.pib_home.Size = new System.Drawing.Size(48, 48);
            this.pib_home.TabIndex = 3;
            this.pib_home.TabStop = false;
            // 
            // lbl_home
            // 
            this.lbl_home.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_home.AutoSize = true;
            this.lbl_home.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home.ForeColor = System.Drawing.Color.White;
            this.lbl_home.Location = new System.Drawing.Point(21, 62);
            this.lbl_home.Name = "lbl_home";
            this.lbl_home.Size = new System.Drawing.Size(52, 20);
            this.lbl_home.TabIndex = 4;
            this.lbl_home.Text = "Home";
            // 
            // gdc_topBar
            // 
            this.gdc_topBar.TargetControl = this.pnl_topBar;
            // 
            // pnl_body
            // 
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(92, 59);
            this.pnl_body.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(1200, 628);
            this.pnl_body.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 687);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.pnl_sideBar);
            this.Controls.Add(this.pnl_topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Educational_App";
            this.pnl_topBar.ResumeLayout(false);
            this.pnl_topBar.PerformLayout();
            this.pnl_sideBar.ResumeLayout(false);
            this.pnl_dashboard.ResumeLayout(false);
            this.pnl_dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_dashboard)).EndInit();
            this.pnl_courses.ResumeLayout(false);
            this.pnl_courses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_courses)).EndInit();
            this.pnl_members.ResumeLayout(false);
            this.pnl_members.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_members)).EndInit();
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_login)).EndInit();
            this.pnl_start.ResumeLayout(false);
            this.pnl_start.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pib_home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_topBar;
        private System.Windows.Forms.Panel pnl_sideBar;
        private System.Windows.Forms.Button btn_exit;
        private Guna.UI2.WinForms.Guna2DragControl gdc_topBar;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Panel pnl_start;
        private System.Windows.Forms.PictureBox pib_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pib_home;
        private System.Windows.Forms.Label lbl_home;
        private System.Windows.Forms.Panel pnl_members;
        private System.Windows.Forms.PictureBox pib_members;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_courses;
        private System.Windows.Forms.PictureBox pib_courses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_dashboard;
        private System.Windows.Forms.PictureBox pib_dashboard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl_body;
    }
}

