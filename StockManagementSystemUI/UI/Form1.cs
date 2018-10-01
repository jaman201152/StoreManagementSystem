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
using StockManagementSystemUI.Model;

namespace StockManagementSystemUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
           

             // get value from user 
            Login login = new Login();
            login.Username = usernameTextBox.Text;
            login.Password = passwordTextBox.Text;

            // connect to server to check user data
         
            SqlConnection con = new SqlConnection(Common.ConnectionString());

            string query = @"SELECT COUNT(*) FROM Login WHERE Username='"+login.Username+"' AND Password='"+login.Password+"' ";

            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable dt = new DataTable();


            dr.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide(); // hide current window
                DashboardFormUI dashboard = new DashboardFormUI();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Pleae check your Username and Password.");
            }
            con.Close();

           
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
