using System;
using System.Data;
using System.Windows.Forms;
namespace TaskManagementApp
{
    public partial class LeaderForm : Form
    {

        private string _leaderUsername;

        public LeaderForm(string username)
        {
            InitializeComponent();
            _leaderUsername = username;
        }

        public LeaderForm()
        {

            InitializeComponent();
            this.Load += LeaderForm_Load;
        }



        private void LoadAssignees()
        {
            try
            {

                string query = "SELECT UserID, UserName FROM Users WHERE Role = @role";


                DataTable assignees = DatabaseHelper.ExecuteQuery(query, cmd =>
                {
                    cmd.Parameters.AddWithValue("@role", "Member");
                });

                if (assignees.Rows.Count > 0)
                {

                    comboBoxAssignee.DataSource = assignees;
                    comboBoxAssignee.DisplayMember = "UserName";
                    comboBoxAssignee.ValueMember = "UserID";
                }
                else
                {
                    MessageBox.Show("No members found to assign tasks.");
                    comboBoxAssignee.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading assignees: " + ex.Message);
                Logger.WriteLog("Error Loading Assignees", $"Failed to load assignees: {ex.Message}");
            }
        }



        private void LoadTasks(bool includeCompleted = false)
        {
            try
            {

                string query = includeCompleted
                    ? "SELECT TaskID, TaskName, Description, Priority, Deadline, AssigneeID, CreatedBy, Comments, Status FROM Tasks"
                    : "SELECT TaskID, TaskName, Description, Priority, Deadline, AssigneeID, CreatedBy, Comments, Status FROM Tasks WHERE Status != 'Completed'";


                DataTable dataTable = DatabaseHelper.ExecuteQuery(query);

                if (dataTable.Rows.Count > 0)
                {

                    dataGridViewTasks.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No tasks found.");
                    dataGridViewTasks.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading tasks: " + ex.Message);
                Logger.WriteLog("Error Loading Tasks", $"Failed to load tasks: {ex.Message}");
            }
        }






        private void btnCreateTask_Click(object sender, EventArgs e)
        {

            string taskName = txtTaskName.Text;
            string description = txtDescription.Text;
            string priority = comboBoxPriority.SelectedItem?.ToString();
            DateTime deadline = dateTimePickerDeadline.Value;


            if (comboBoxAssignee.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid assignee.");
                return;
            }
            int assigneeId = Convert.ToInt32(comboBoxAssignee.SelectedValue);


            string query = "INSERT INTO Tasks (TaskName, Description, Priority, Deadline, AssigneeID, CreatedBy) VALUES (@taskName, @description, @priority, @deadline, @assigneeId, @createdBy)";


            DatabaseHelper.ExecuteNonQuery(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@taskName", taskName);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@priority", priority);
                cmd.Parameters.AddWithValue("@deadline", deadline);
                cmd.Parameters.AddWithValue("@assigneeId", assigneeId);
                cmd.Parameters.AddWithValue("@createdBy", _leaderUsername);
            });


            Logger.WriteLog("Task Created", $"Task '{taskName}' assigned to '{comboBoxAssignee.Text}'.");


            txtTaskName.Text = "";
            txtDescription.Text = "";
            comboBoxPriority.SelectedIndex = -1;
            comboBoxAssignee.SelectedIndex = -1;
            dateTimePickerDeadline.Value = DateTime.Today;


            LoadTasks();

            MessageBox.Show("Task created and assigned successfully.");
        }




        private void LeaderForm_Load(object sender, EventArgs e)
        {

            comboBoxPriority.Items.Add("High");
            comboBoxPriority.Items.Add("Medium");
            comboBoxPriority.Items.Add("Low");

            LoadAssignees();
            LoadTasks();
        }
        private void btnViewReport_Click_1(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
        }

        private void btnFinishTask_Click(object sender, EventArgs e)
        {

            if (dataGridViewTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task to finish.");
                return;
            }


            int taskId = Convert.ToInt32(dataGridViewTasks.SelectedRows[0].Cells["TaskID"].Value);
            string taskName = dataGridViewTasks.SelectedRows[0].Cells["TaskName"].Value.ToString(); // Assuming the task name is in the "TaskName" column


            string query = "UPDATE Tasks SET Status = 'Completed', CompletedAt = @completedAt WHERE TaskID = @taskId";

            try
            {

                DatabaseHelper.ExecuteNonQuery(query, cmd =>
                {
                    cmd.Parameters.AddWithValue("@completedAt", DateTime.Now);
                    cmd.Parameters.AddWithValue("@taskId", taskId);
                });


                Logger.WriteLog("Task Completed", $"Task '{taskName}' (ID: {taskId}) marked as completed.");

                MessageBox.Show("Task marked as completed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the task: {ex.Message}");
            }


            LoadTasks();
        }

        private void checkBoxShowCompleted_CheckedChanged(object sender, EventArgs e)
        {
            LoadTasks(checkBoxShowCompleted.Checked);
            this.checkBoxShowCompleted.CheckedChanged += new System.EventHandler(this.checkBoxShowCompleted_CheckedChanged);

        }

        private void LeaderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
