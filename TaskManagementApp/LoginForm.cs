using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TaskManagementApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private string ValidateLogin(string username, string password)
        {
            string query = "SELECT Role FROM Users WHERE UserName = @username AND Password = @password";
            return DatabaseHelper.ExecuteScalar(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
            })?.ToString();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            
            string role = ValidateLogin(username, password);

            if (role != null)
            {
                Logger.WriteLog("Login Success", $"User '{username}' logged in as '{role}'.");
                this.Hide();

             
                if (role == "Admin")
                {
                    Form1 adminForm = new Form1();
                    adminForm.Show();
                }
                else if (role == "Leader")
                {
                    LeaderForm leaderForm = new LeaderForm(username);
                    leaderForm.Show();
                }
                else if (role == "Member")
                {
                    UserForm userForm = new UserForm(username);
                    userForm.Show();
                }
            }
            else
            {
                Logger.WriteLog("Login Failed", $"Failed login attempt for username '{username}'.");
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}