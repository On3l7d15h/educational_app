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
    public partial class FormStudents : Form
    {
        private bool isEditable = false;
        private string id;
        Panel[] panels;
        public FormStudents(Panel[] panels)
        {
            InitializeComponent();
            dgv_students.DataSource = DataMain.refresh("vw_students");
            this.panels = panels;
        }

        private void btm_refresh_Click(object sender, EventArgs e)
        {
            dgv_students.DataSource = DataMain.refresh("vw_students");
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (isEditable == false)
            {
                try
                {
                    DataMain.insert("students", txt_name.Text, txt_lastname.Text, txt_email.Text, txt_phone.Text, txt_password.Text);
                    MessageBox.Show("Student" + txt_name.Text + " " + txt_lastname.Text + " has been inserted successfully !");
                    dgv_students.DataSource = DataMain.refresh("vw_students");
                    ClearTextBoxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    DataMain.edit("students", txt_name.Text, txt_lastname.Text, txt_email.Text, txt_phone.Text, txt_password.Text, Int32.Parse(id));
                    MessageBox.Show("Student " + txt_name.Text + " " + txt_lastname.Text + " has been updated successfully !");
                    dgv_students.DataSource = DataMain.refresh("vw_students");
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_students.SelectedRows.Count > 0)
            {
                isEditable = true;
                txt_name.Text = dgv_students.CurrentRow.Cells["username"].Value.ToString();
                txt_lastname.Text = dgv_students.CurrentRow.Cells["surname"].Value.ToString();
                txt_email.Text = dgv_students.CurrentRow.Cells["email"].Value.ToString();
                txt_phone.Text = dgv_students.CurrentRow.Cells["phone"].Value.ToString();
                txt_password.Text = dgv_students.CurrentRow.Cells["password"].Value.ToString();
                txt_name.Text = dgv_students.CurrentRow.Cells["username"].Value.ToString();
                id = dgv_students.CurrentRow.Cells["id"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Please, select a row to edit");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_students.SelectedRows.Count > 0)
            {
                id = dgv_students.CurrentRow.Cells["id"].Value.ToString();
                DataMain.delete("students", Int32.Parse(id));
                dgv_students.DataSource = DataMain.refresh("vw_students");
            }
            else
            {
                MessageBox.Show("Please, select a row to edit");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.roll == "Director")
            {
                MainCompany.ChangePanelForm(panels, "dashboard");
            }
            else
            {
                MainCompany.ChangePanelForm(panels, "members");
            }
        }
    }
}
