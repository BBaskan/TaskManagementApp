using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagementApp
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            LoadReport(); 
        }

        private void LoadReport()
        {
            
            string query = @"
            SELECT Users.UserName, COUNT(Tasks.TaskID) AS TaskCount 
            FROM Tasks
            JOIN Users ON Tasks.AssigneeID = Users.UserID
            GROUP BY Users.UserName
            ORDER BY TaskCount DESC";

         
            DataTable reportData = DatabaseHelper.ExecuteQuery(query);


            dataGridViewReport.DataSource = reportData;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }

        private void ReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
