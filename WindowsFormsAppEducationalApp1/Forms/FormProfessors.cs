using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Microsoft.SqlServer.Server;

namespace WindowsFormsAppEducationalApp1.Forms
{
    public partial class FormProfessors : Form
    {
        private bool isEditable = false;
        private string id;
        Panel[] panels;

        public FormProfessors(Panel[] panels) 
        {
            InitializeComponent();
            dgv_professors.DataSource = DataMain.refresh("vw_professors");
            this.panels = panels;
        }

        private void btm_refresh_Click(object sender, EventArgs e)
        {      
           dgv_professors.DataSource = DataMain.refresh("vm_professors");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if(Program.roll == "Director")
            {
                MainCompany.ChangePanelForm(panels, "dashboard");
            } else
            {
                MainCompany.ChangePanelForm(panels, "members");
            }
        }

        private void lbl_subtitle_email_Click(object sender, EventArgs e)
        {

        }

        private void gtxt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if(isEditable == false)
            {
                try
                {
                    DataMain.insert("professors", txt_name.Text, txt_lastname.Text, txt_email.Text, txt_phone.Text, txt_password.Text);
                    MessageBox.Show("Professor " + txt_name.Text + txt_lastname.Text + " has been inserted successfully !");
                    dgv_professors.DataSource = DataMain.refresh("professors");
                    ClearTextBoxes();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                try
                {
                    DataMain.edit("professors", txt_name.Text, txt_lastname.Text, txt_email.Text, txt_phone.Text, txt_password.Text, Int32.Parse(id));
                    MessageBox.Show("Professor " + txt_name.Text + txt_lastname.Text + " has been updated successfully !");
                    dgv_professors.DataSource = DataMain.refresh("professors");
                    isEditable = false;
                    ClearTextBoxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(dgv_professors.SelectedRows.Count > 0) 
            {
                isEditable = true;
                txt_name.Text = dgv_professors.CurrentRow.Cells["username"].Value.ToString();
                txt_lastname.Text = dgv_professors.CurrentRow.Cells["surname"].Value.ToString();
                txt_email.Text = dgv_professors.CurrentRow.Cells["email"].Value.ToString();
                txt_phone.Text = dgv_professors.CurrentRow.Cells["phone"].Value.ToString();
                txt_password.Text = dgv_professors.CurrentRow.Cells["password"].Value.ToString();
                txt_name.Text = dgv_professors.CurrentRow.Cells["username"].Value.ToString();
                id = dgv_professors.CurrentRow.Cells["id"].Value.ToString();

            } else
            {
                MessageBox.Show("Please, select a row to edit");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormProfessors_Load(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_professors.SelectedRows.Count > 0)
            {
                id = dgv_professors.CurrentRow.Cells["id"].Value.ToString();
                DataMain.delete("professors", Int32.Parse(id));
                dgv_professors.DataSource = DataMain.refresh("professors");
            }
            else
            {
                MessageBox.Show("Please, select a row to edit");
            }
        }
    }
}
