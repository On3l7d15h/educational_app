using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// importing
using WindowsFormsAppEducationalApp1;

namespace WindowsFormsAppEducationalApp1.Forms
{
    public partial class FormLogin : Form
    {
        Panel[] panels;
        public FormLogin(Panel[] panels)
        {
            this.panels = panels;
            InitializeComponent();
        }

        private void gbtn_submit_Click(object sender, EventArgs e)
        {
            bool answer = MainCompany.GetUser(gtxt_email.Text, gtxt_password.Text);

            if (answer)
            {
                MainCompany.SetVisiblePanelsForm(panels);
                MainCompany.ChangePanelForm(panels, "start");
            }
        }

        private void gtxt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
