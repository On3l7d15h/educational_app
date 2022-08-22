namespace WindowsFormsAppEducationalApp1.Forms
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.lbl_maintitle = new System.Windows.Forms.Label();
            this.pib_main = new System.Windows.Forms.PictureBox();
            this.lbl_desc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pib_main)).BeginInit();
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
            this.lbl_maintitle.Location = new System.Drawing.Point(533, 23);
            this.lbl_maintitle.Name = "lbl_maintitle";
            this.lbl_maintitle.Size = new System.Drawing.Size(97, 38);
            this.lbl_maintitle.TabIndex = 2;
            this.lbl_maintitle.Text = "Home";
            // 
            // pib_main
            // 
            this.pib_main.BackColor = System.Drawing.SystemColors.Control;
            this.pib_main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pib_main.BackgroundImage")));
            this.pib_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pib_main.Location = new System.Drawing.Point(248, 89);
            this.pib_main.Name = "pib_main";
            this.pib_main.Size = new System.Drawing.Size(686, 437);
            this.pib_main.TabIndex = 4;
            this.pib_main.TabStop = false;
            // 
            // lbl_desc
            // 
            this.lbl_desc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_desc.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            this.lbl_desc.Location = new System.Drawing.Point(214, 561);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(767, 28);
            this.lbl_desc.TabIndex = 3;
            this.lbl_desc.Text = "At this time, you\'re not logged, please click the login button to start your jour" +
    "ney\r\n";
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 628);
            this.Controls.Add(this.pib_main);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.lbl_maintitle);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStart";
            this.Text = "FormStart";
            ((System.ComponentModel.ISupportInitialize)(this.pib_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_maintitle;
        private System.Windows.Forms.PictureBox pib_main;
        private System.Windows.Forms.Label lbl_desc;
    }
}