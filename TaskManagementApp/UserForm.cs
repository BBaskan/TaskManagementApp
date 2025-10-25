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

namespace TaskManagementApp
{
    public partial class UserForm : Form
    {
        private string loggedInUser;

        public UserForm(string username) 
        {
            InitializeComponent();
            loggedInUser = username;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            LoadUserTasks(loggedInUser); 
        }

        private void LoadUserTasks(string username)
        {
            try
            {

                string query = @"
            SELECT 
                t.TaskID, t.TaskName, t.Description, t.Priority, t.Deadline, t.Status, t.CreatedBy, t.Comments
            FROM Tasks t
            INNER JOIN Users u ON t.AssigneeID = u.UserID
            WHERE u.UserName = @username";


                DataTable dataTable = DatabaseHelper.ExecuteQuery(query, cmd =>
                {
                    cmd.Parameters.AddWithValue("@username", username);
                });

                if (dataTable.Rows.Count > 0)
                {

                    dataGridViewTasks.DataSource = dataTable;
                    Logger.WriteLog("User Tasks Loaded", $"Tasks for user '{username}' loaded successfully.");
                }
                else
                {
                    MessageBox.Show($"No tasks found for the user: {username}");
                    Logger.WriteLog("No Tasks Found", $"No tasks found for user '{username}'.");
                    dataGridViewTasks.DataSource = null; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading tasks: " + ex.Message);
                Logger.WriteLog("Task Loading Error", $"Error loading tasks for user '{username}': {ex.Message}");
            }
        }



        private void btnAddComment_Click(object sender, EventArgs e)
        {

            if (dataGridViewTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task to add a comment.");
                return;
            }


            int taskID = Convert.ToInt32(dataGridViewTasks.SelectedRows[0].Cells["TaskID"].Value);

            string comment = txtComment.Text.Trim(); 
            if (string.IsNullOrWhiteSpace(comment))
            {
                MessageBox.Show("Please enter a valid comment.");
                return;
            }

            try
            {

                string query = @"
            UPDATE Tasks 
            SET Comments = 
                CASE 
                    WHEN Comments IS NULL THEN @comment 
                    ELSE Comments + CHAR(13) + CHAR(10) + @comment 
                END
            WHERE TaskID = @taskID";


                DatabaseHelper.ExecuteNonQuery(query, cmd =>
                {
                    cmd.Parameters.AddWithValue("@comment", $"{DateTime.Now}: {comment}"); 
                    cmd.Parameters.AddWithValue("@taskID", taskID);
                });

                Logger.WriteLog("Comment Added", $"Comment added to TaskID '{taskID}' by '{loggedInUser}'.");

                MessageBox.Show("Comment added successfully.");
                txtComment.Clear(); 
                LoadUserTasks(loggedInUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the comment: " + ex.Message);
                Logger.WriteLog("Error Adding Comment", $"Failed to add comment to TaskID '{taskID}': {ex.Message}");
            }
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}