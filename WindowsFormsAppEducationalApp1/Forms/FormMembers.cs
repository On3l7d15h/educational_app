using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEducationalApp1.Forms
{
    public partial class FormMembers : Form
    {

        static FormMessageBox frmMessageBox;
        Panel[] panels;
        public FormMembers(Panel[] panels)
        {
            InitializeComponent();
            this.panels = panels;
        }

        private void pnl_student_sec_Click(object sender, EventArgs e)
        {
            MainCompany.ChangePanelForm(panels, "students");
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            frmMessageBox = new FormMessageBox("This is in Beta, it's not available yet...");
            frmMessageBox.ShowDialog();
        }

        private void pnl_student_sec_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
