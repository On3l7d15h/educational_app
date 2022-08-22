namespace WindowsFormsAppEducationalApp1.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lbl_logintitle = new System.Windows.Forms.Label();
            this.gtxt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_subtitle_email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gtxt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbtn_submit = new Guna.UI2.WinForms.Guna2Button();
            this.pib_main = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pib_main)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_logintitle
            // 
            this.lbl_logintitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_logintitle.AutoSize = true;
            this.lbl_logintitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_logintitle.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logintitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            this.lbl_logintitle.Location = new System.Drawing.Point(45, 86);
            this.lbl_logintitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_logintitle.Name = "lbl_logintitle";
            this.lbl_logintitle.Size = new System.Drawing.Size(71, 30);
            this.lbl_logintitle.TabIndex = 2;
            this.lbl_logintitle.Text = "Login";
            // 
            // gtxt_email
            // 
            this.gtxt_email.BorderRadius = 3;
            this.gtxt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxt_email.DefaultText = "";
            this.gtxt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_email.DisabledState.Parent = this.gtxt_email;
            this.gtxt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_email.FocusedState.Parent = this.gtxt_email;
            this.gtxt_email.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtxt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_email.HoverState.Parent = this.gtxt_email;
            this.gtxt_email.Location = new System.Drawing.Point(50, 184);
            this.gtxt_email.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gtxt_email.Name = "gtxt_email";
            this.gtxt_email.PasswordChar = '\0';
            this.gtxt_email.PlaceholderText = "";
            this.gtxt_email.SelectedText = "";
            this.gtxt_email.ShadowDecoration.Parent = this.gtxt_email;
            this.gtxt_email.Size = new System.Drawing.Size(230, 37);
            this.gtxt_email.TabIndex = 3;
            // 
            // lbl_subtitle_email
            // 
            this.lbl_subtitle_email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_subtitle_email.AutoSize = true;
            this.lbl_subtitle_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtitle_email.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitle_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            this.lbl_subtitle_email.Location = new System.Drawing.Point(46, 158);
            this.lbl_subtitle_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_subtitle_email.Name = "lbl_subtitle_email";
            this.lbl_subtitle_email.Size = new System.Drawing.Size(46, 20);
            this.lbl_subtitle_email.TabIndex = 4;
            this.lbl_subtitle_email.Text = "Email";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(46, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gtxt_password
            // 
            this.gtxt_password.BorderRadius = 3;
            this.gtxt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxt_password.DefaultText = "";
            this.gtxt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_password.DisabledState.Parent = this.gtxt_password;
            this.gtxt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_password.FocusedState.Parent = this.gtxt_password;
            this.gtxt_password.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtxt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_password.HoverState.Parent = this.gtxt_password;
            this.gtxt_password.Location = new System.Drawing.Point(51, 274);
            this.gtxt_password.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.gtxt_password.Name = "gtxt_password";
            this.gtxt_password.PasswordChar = '*';
            this.gtxt_password.PlaceholderText = "";
            this.gtxt_password.SelectedText = "";
            this.gtxt_password.ShadowDecoration.Parent = this.gtxt_password;
            this.gtxt_password.Size = new System.Drawing.Size(230, 37);
            this.gtxt_password.TabIndex = 5;
            this.gtxt_password.TextChanged += new System.EventHandler(this.gtxt_password_TextChanged);
            // 
            // gbtn_submit
            // 
            this.gbtn_submit.BorderRadius = 3;
            this.gbtn_submit.CheckedState.Parent = this.gbtn_submit;
            this.gbtn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtn_submit.CustomImages.Parent = this.gbtn_submit;
            this.gbtn_submit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            this.gbtn_submit.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtn_submit.ForeColor = System.Drawing.Color.White;
            this.gbtn_submit.HoverState.Parent = this.gbtn_submit;
            this.gbtn_submit.Location = new System.Drawing.Point(52, 362);
            this.gbtn_submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbtn_submit.Name = "gbtn_submit";
            this.gbtn_submit.ShadowDecoration.Parent = this.gbtn_submit;
            this.gbtn_submit.Size = new System.Drawing.Size(135, 37);
            this.gbtn_submit.TabIndex = 7;
            this.gbtn_submit.Text = "Sign in";
            this.gbtn_submit.Click += new System.EventHandler(this.gbtn_submit_Click);
            // 
            // pib_main
            // 
            this.pib_main.BackColor = System.Drawing.SystemColors.Control;
            this.pib_main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pib_main.BackgroundImage")));
            this.pib_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pib_main.Location = new System.Drawing.Point(376, 41);
            this.pib_main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pib_main.Name = "pib_main";
            this.pib_main.Size = new System.Drawing.Size(479, 427);
            this.pib_main.TabIndex = 5;
            this.pib_main.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 510);
            this.Controls.Add(this.pib_main);
            this.Controls.Add(this.gtxt_password);
            this.Controls.Add(this.gbtn_submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_subtitle_email);
            this.Controls.Add(this.gtxt_email);
            this.Controls.Add(this.lbl_logintitle);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormLogin";
            this.Text = "FormStart";
            ((System.ComponentModel.ISupportInitialize)(this.pib_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_logintitle;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_email;
        private System.Windows.Forms.Label lbl_subtitle_email;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_password;
        private Guna.UI2.WinForms.Guna2Button gbtn_submit;
        private System.Windows.Forms.PictureBox pib_main;
    }
}