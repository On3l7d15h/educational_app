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
    public partial class FormMessageBox : Form
    {
        Form frmMessage;
        public FormMessageBox(string message)
        {
            InitializeComponent();
            frmMessage = this;
            lbl_message.Text = message;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            MainCompany.CloseForm(frmMessage);
        }
    }
}
