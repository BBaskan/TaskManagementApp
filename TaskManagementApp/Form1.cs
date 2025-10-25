using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        
        LoadData();
    }

    private void LoadData()
    {
        try
        {
            string query = "SELECT * FROM Users";


            DataTable dataTable = DatabaseHelper.ExecuteQuery(query);


            dataGridView1.DataSource = dataTable;

            
        }
        catch (Exception ex)
        {

            Logger.WriteLog("Data Load Error", $"An error occurred while loading user data: {ex.Message}");


            MessageBox.Show("An error occurred: " + ex.Message);
        }
    }



    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtGroupID = new System.Windows.Forms.TextBox();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(749, 438);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(889, 62);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(889, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(889, 142);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(100, 22);
            this.txtRole.TabIndex = 3;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(889, 223);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(100, 36);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtGroupID
            // 
            this.txtGroupID.Location = new System.Drawing.Point(889, 182);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.Size = new System.Drawing.Size(100, 22);
            this.txtGroupID.TabIndex = 5;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(889, 285);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(100, 37);
            this.btnEditUser.TabIndex = 6;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(889, 348);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(100, 35);
            this.btnRemoveUser.TabIndex = 8;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(806, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(806, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(806, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(809, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "GroupID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(0, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(533, 60);
            this.label5.TabIndex = 13;
            this.label5.Text = "İf you have any problems please contact with your supervisor or admin\r\nFor inform" +
    "ation or contact: onurbaskan419@gmail.com\r\n\r\n";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1037, 570);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.txtGroupID);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BTTRFLY";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private DataGridView dataGridView1;
    private TextBox txtUsername;
    private TextBox txtPassword;
    private TextBox txtRole;
    private Button btnAddUser;
    private TextBox txtGroupID;

    private void btnAddUser_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string password = txtPassword.Text;
        string role = txtRole.Text;
        int groupId;

        
        if (!int.TryParse(txtGroupID.Text, out groupId))
        {
            MessageBox.Show("Please enter a valid Group ID.");
            return;
        }


       
        SaveUser(username, password, role, groupId);

        {
            Logger.WriteLog("User Added", $"User '{txtUsername.Text}' added with role '{txtRole.Text}'.");
        }


        LoadUsers();
    }

    public void SaveUser(string username, string password, string role, int groupId)
    {
        try
        {
            string query = "INSERT INTO Users (UserName, Password, Role, GroupID) VALUES (@username, @password, @role, @groupId)";
            DatabaseHelper.ExecuteNonQuery(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@groupId", groupId);
            });
            MessageBox.Show("User saved successfully.");
        }
        catch (Exception ex)
        {

            Logger.WriteLog("User Save Error", $"An error occurred while saving user '{username}': {ex.Message}");

            MessageBox.Show("An error occurred while saving the user: " + ex.Message);
        }
    }


    private void LoadUsers()
    {
        string query = "SELECT * FROM Users";
dataGridView1.DataSource = DatabaseHelper.ExecuteQuery(query);

    }

    private Button btnEditUser;

    private void btnEditUser_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count > 0)
        {
            try
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int userId = Convert.ToInt32(selectedRow.Cells["UserID"].Value);

                string newUsername = txtUsername.Text.Trim();
                string newPassword = txtPassword.Text.Trim();
                string newRole = txtRole.Text.Trim();
                int newGroupId;


                if (!int.TryParse(txtGroupID.Text, out newGroupId))
                {
                    MessageBox.Show("Please enter a valid Group ID.");
                    return;
                }


                string oldUsername = selectedRow.Cells["UserName"].Value.ToString();
                string oldRole = selectedRow.Cells["Role"].Value.ToString();
                int oldGroupId = Convert.ToInt32(selectedRow.Cells["GroupID"].Value);

                Logger.WriteLog("User Edit Initiated",
                    $"Editing UserID: {userId}, Old Data: Username='{oldUsername}', Role='{oldRole}', GroupID={oldGroupId}");


                UpdateUser(userId, newUsername, newPassword, newRole, newGroupId);


                Logger.WriteLog("User Edited",
                    $"UserID: {userId} updated. New Data: Username='{newUsername}', Role='{newRole}', GroupID={newGroupId}");


                LoadUsers();

                MessageBox.Show("User updated successfully.");
            }
            catch (Exception ex)
            {

                Logger.WriteLog("User Edit Error",
                    $"Error occurred while editing user: {ex.Message}");

                MessageBox.Show("An error occurred while updating the user: " + ex.Message);
            }
        }
        else
        {
            MessageBox.Show("Please select a user to edit.");
        }
    }



    private void UpdateUser(int userId, string username, string password, string role, int groupId)
    {
        try
        {
            string query = "UPDATE Users SET UserName = @username, Password = @password, Role = @role, GroupID = @groupId WHERE UserID = @userId";

            DatabaseHelper.ExecuteNonQuery(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@groupId", groupId);
            });


            Logger.WriteLog("User Updated",
                $"UserID: {userId} updated with new data: Username='{username}', Role='{role}', GroupID={groupId}");

            MessageBox.Show("User updated successfully.");
        }
        catch (Exception ex)
        {

            Logger.WriteLog("User Update Error",
                $"Error while updating UserID: {userId}. Exception: {ex.Message}");

            MessageBox.Show("An error occurred while updating the user: " + ex.Message);
        }
    }



    private Button btnRemoveUser;

    private void btnRemoveUser_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count > 0)
        {
            try
            {

                int userId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UserID"].Value);
                string username = dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString();


                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete the user '{username}'?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    DeleteUser(userId);


                    Logger.WriteLog("User Removed", $"User '{username}' (ID: {userId}) removed from the system.");


                    LoadUsers();


                    MessageBox.Show($"User '{username}' has been removed successfully.");
                }
            }
            catch (Exception ex)
            {

                Logger.WriteLog("User Removal Error", $"Error occurred while removing a user. Exception: {ex.Message}");


                MessageBox.Show("An error occurred while removing the user: " + ex.Message);
            }
        }
        else
        {

            MessageBox.Show("Please select a user to remove.");
        }
    }


    private void DeleteUser(int userId)
    {
        try
        {

            string query = "DELETE FROM Users WHERE UserID = @userId";


            DatabaseHelper.ExecuteNonQuery(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@userId", userId);
            });


            MessageBox.Show("User deleted successfully.");
        }
        catch (SqlException sqlEx)
        {

            Logger.WriteLog("SQL Error", $"Error while deleting user with ID {userId}: {sqlEx.Message}");
            MessageBox.Show($"A database error occurred while deleting the user. Details: {sqlEx.Message}");
        }
        catch (Exception ex)
        {

            Logger.WriteLog("Deletion Error", $"Unexpected error while deleting user with ID {userId}: {ex.Message}");
            MessageBox.Show("An unexpected error occurred while deleting the user. Please try again later.");
        }
    }



    private void Exit_Click(object sender, EventArgs e)
    {
        Environment.Exit(0);
    }

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }

    private Label label5;
}



