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
    public partial class FormDashboard : Form
    {
        Panel[] panels;
        FormMessageBox frmMessageBox;
        public FormDashboard(Panel[] panels)
        {
            InitializeComponent();
            this.panels = panels;
        }

        private void pnl_students_Click(object sender, EventArgs e)
        {
            MainCompany.ChangePanelForm(panels, "students");
        }

        private void pnl_professors_Click(object sender, EventArgs e)
        {
            MainCompany.ChangePanelForm(panels, "professors");
        }

        private void pnl_subjects_Click(object sender, EventArgs e)
        {
            frmMessageBox = new FormMessageBox("This is in Beta, it's not available yet...");
            frmMessageBox.ShowDialog();
        }

        private void lbl_students_Click(object sender, EventArgs e)
        {

        }

        private void pnl_students_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pib_professors_sec_Click(object sender, EventArgs e)
        {
            MainCompany.ChangePanelForm(panels, "professors");
        }

        private void lbl_professors_Click(object sender, EventArgs e)
        {
            
        }

        private void pnl_professors_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pnl_subjects_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
