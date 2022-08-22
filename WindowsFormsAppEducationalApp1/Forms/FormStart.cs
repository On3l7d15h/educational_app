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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();

            if (Program.isAuth == true)
            {
                lbl_desc.Text = "";
            }
        }
    }
}
