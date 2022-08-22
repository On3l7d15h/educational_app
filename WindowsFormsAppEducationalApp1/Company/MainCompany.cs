using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
/* importing */
using WindowsFormsAppEducationalApp1.Forms;

namespace WindowsFormsAppEducationalApp1
{
	public class MainCompany
	{

		static FormMessageBox frmMessageBox;

		#region LogicMethods
		public static void CloseForm(Form frmActualForm)
		{
			frmActualForm.Close();
		}

		public static void ChangePanelForm(Panel[] panels, string value)
		{
            panels[0].Controls.Clear();
			switch (value)
			{
				case "start":
					{
						FormStart frmStart = new FormStart();
						frmStart.TopLevel = false;
                        panels[0].Controls.Add(frmStart);
						frmStart.Show();
						break;
					}

				case "login":
					{
						FormLogin frmLogin = new FormLogin(panels);
						frmLogin.TopLevel = false;
                        panels[0].Controls.Add(frmLogin);
						frmLogin.Show();
						break;
					}

				case "courses":
					{
						FormCourses frmCourses = new FormCourses();
						frmCourses.TopLevel = false;
						panels[0].Controls.Add(frmCourses);
						frmCourses.Show();
						break;
					}

				case "members":
					{
						FormMembers frmMembers = new FormMembers(panels);
						frmMembers.TopLevel = false;
						panels[0].Controls.Add(frmMembers);
						frmMembers.Show();
						break;
					}

				case "dashboard":
					{
						FormDashboard frmDashboard = new FormDashboard(panels);
						frmDashboard.TopLevel = false;
						panels[0].Controls.Add(frmDashboard);
						frmDashboard.Show();
						break;
					}

				case "students":
					{
						FormStudents frmStudents = new FormStudents(panels);
						frmStudents.TopLevel = false;
						panels[0].Controls.Add(frmStudents);
						frmStudents.Show();
						break;
					}

				case "subjects":
					{
						FormSubjects frmSubjects = new FormSubjects();
						frmSubjects.TopLevel = false;
						panels[0].Controls.Add(frmSubjects);
						frmSubjects.Show();
						break;
					}

				case "professors":
					{
						FormProfessors frmProfessors = new FormProfessors(panels);
						frmProfessors.TopLevel = false;
						panels[0].Controls.Add(frmProfessors);
						frmProfessors.Show();
						break;
					}

				case "badges":
					{
						FormSpecial frmBadges = new FormSpecial();
						frmBadges.TopLevel = false;
						panels[0].Controls.Add(frmBadges);
						frmBadges.Show();
						break;
					}

				default:
					{
						break;
					}
			}
		}

		public static void SetVisiblePanelsForm(Panel[] panels)
		{
			panels[1].Controls.Remove(panels[2]);
			switch (Program.roll)
			{
				case "Student":
					{
						panels[3].Visible = true;
						break;
					}

				case "Professor":
					{
						panels[3].Visible = true;
						panels[4].Visible = true;
						break;
					}

				case "Director":
					{
						panels[3].Visible = true;
						panels[5].Visible = true;
						break;
					}

				default:
					{
						break;
					}
			}
		}
		#endregion


		public static bool GetUser(string email, string password)
        {
			
			if(email == "" || password == "")
            {
				frmMessageBox = new FormMessageBox("Invalid Credentials");
				frmMessageBox.ShowDialog();
				return false;
            }
			
			bool answer = DataMain.GetUser(email, password);

            if (answer)
            {
				frmMessageBox = new FormMessageBox("Welcome");
				frmMessageBox.ShowDialog();
				return true;
            } 
			else
            {
				frmMessageBox = new FormMessageBox("Bad Login, incorrect credentials");
				frmMessageBox.ShowDialog();
				return false;
			}
        }
	}

}