using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* References */
using WindowsFormsAppEducationalApp1.Forms;

namespace WindowsFormsAppEducationalApp1
{
    public partial class FormMain : Form
    {

        #region Variables
        static Form actualForm;
        static Panel[] panels;
        #endregion
        public FormMain()
        {
            /* Main create instance */
            InitializeComponent();
            this.Name = "frmMain";
            actualForm = this;
            /* filling the Panel Array */
            panels = new Panel[]
            {
                pnl_body,
                pnl_sideBar,
                pnl_login,
                pnl_courses,
                pnl_members,
                pnl_dashboard
            };

            /* Fill another panel */
            MainCompany.ChangePanelForm(panels, "start");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //closing this form
            MainCompany.CloseForm(actualForm);
        }

        private void pnl_login_Click(object sender, EventArgs e)
        { 
            MainCompany.ChangePanelForm(panels, "login");
        }

        private void pnl_start_Click(object sender, EventArgs e)
        {
            MainCompany.ChangePanelForm(panels, "start");
        }

        private void pnl_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_courses_Click(object sender, EventArgs e)
        {
            MainCompany.ChangePanelForm(panels, "courses");
        }

        private void pnl_members_Click(object sender, EventArgs e)
        {
            MainCompany.ChangePanelForm(panels, "members");
        }

        private void pnl_dashboard_Click(object sender, EventArgs e)
        {
            MainCompany.ChangePanelForm(panels, "dashboard");
        }

        private void pib_dashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
