using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsAppEducationalApp1
{
    public class DataMain
    {
        /* stringConnection */
        private static string stringConnection = @"server=DESKTOP-BB9NQHL\SQLEXPRESS; database=educational_app; integrated security = true";

        /* Methods */
        public static bool GetUser(string email, string password)
        {
            SqlConnection conn = new SqlConnection(stringConnection);
            SqlCommand comm = new SqlCommand($"SELECT * FROM students WHERE email = '{email}' AND password = HASHBYTES('SHA2_512', '{password}')", conn);
            Object data;

            try
            {
                conn.Open();
                data = comm.ExecuteScalar();

                if (data != null)
                {
                    Program.roll = "Student";
                    Program.isAuth = true;
                    return true;
                }

                comm = new SqlCommand($"SELECT * FROM professors WHERE email = '{email}' AND password = HASHBYTES('SHA2_512', '{password}')", conn);
                data = comm.ExecuteScalar();


                if (data != null)
                {
                    Program.roll = "Professor";
                    Program.isAuth = true;
                    return true;
                }

                comm = new SqlCommand($"SELECT * FROM directors WHERE email = '{email}' AND password = HASHBYTES('SHA2_512', '{password}')", conn);
                data = comm.ExecuteScalar();

                if (data != null)
                {
                    Program.roll = "Director";
                    Program.isAuth = true;
                    return true;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}", "SAE: Error");
            }
            finally
            {
                conn.Close();
            }

            return false;
        }

        public static DataTable refresh(string tableName)
        {
            SqlConnection conn = new SqlConnection(stringConnection);
            SqlCommand comm = new SqlCommand($"SELECT * FROM {tableName}", conn);
            DataTable table = new DataTable();
            SqlDataReader read;
            //Object data;
           conn.Open();

           read = comm.ExecuteReader();

           table.Load(read);

           return table;
        }

        public static void insert(string tableName, string username, string surname, string email, string phone, string password)
        {
            int roll = 1;
            if (tableName == "professors")
            {
                roll = 2;
            }
            if (tableName == "directors")
            {
                roll = 3;
            }
            SqlConnection conn = new SqlConnection(stringConnection);
            SqlCommand comm = new SqlCommand($"INSERT INTO {tableName} VALUES('{username}', '{surname}', '{email}', '{phone}', HASHBYTES('SHA2_512', '{password}'), 1, {roll});", conn);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
        }

        public static void edit(string tableName, string username, string surname, string email, string phone, string password, int id)
        {
            SqlConnection conn = new SqlConnection(stringConnection);
            SqlCommand comm = new SqlCommand($"UPDATE {tableName} SET username='{username}', surname='{surname}', email='{email}', phone='{phone}', password=HASHBYTES('SHA2_512', '{password}') WHERE id='{id}';", conn);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
        }

        public static void delete(string tableName, int id)
        {
            SqlConnection conn = new SqlConnection(stringConnection);
            SqlCommand comm = new SqlCommand($"DELETE FROM {tableName} WHERE id = {id}", conn);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
        }
    }
}