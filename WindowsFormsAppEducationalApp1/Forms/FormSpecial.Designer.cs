namespace WindowsFormsAppEducationalApp1.Forms
{
    partial class FormSpecial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSpecial));
            this.dgv_badges = new System.Windows.Forms.DataGridView();
            this.lbl_special = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_badges)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_badges
            // 
            this.dgv_badges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_badges.Location = new System.Drawing.Point(24, 125);
            this.dgv_badges.Name = "dgv_badges";
            this.dgv_badges.RowHeadersWidth = 51;
            this.dgv_badges.RowTemplate.Height = 24;
            this.dgv_badges.Size = new System.Drawing.Size(648, 410);
            this.dgv_badges.TabIndex = 13;
            // 
            // lbl_special
            // 
            this.lbl_special.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_special.AutoSize = true;
            this.lbl_special.BackColor = System.Drawing.Color.Transparent;
            this.lbl_special.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_special.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            this.lbl_special.Location = new System.Drawing.Point(529, 9);
            this.lbl_special.Name = "lbl_special";
            this.lbl_special.Size = new System.Drawing.Size(114, 38);
            this.lbl_special.TabIndex = 14;
            this.lbl_special.Text = "Badges";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(24, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(38, 38);
            this.btn_back.TabIndex = 15;
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // FormSpecial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 628);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_special);
            this.Controls.Add(this.dgv_badges);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSpecial";
            this.Text = "FormSpecial";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_badges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_badges;
        private System.Windows.Forms.Label lbl_special;
        private System.Windows.Forms.Button btn_back;
    }
}