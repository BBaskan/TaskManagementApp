namespace TaskManagementApp
{
    partial class LeaderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaderForm));
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.comboBoxAssignee = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.btnFinishTask = new System.Windows.Forms.Button();
            this.checkBoxShowCompleted = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Location = new System.Drawing.Point(28, 31);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.RowHeadersWidth = 51;
            this.dataGridViewTasks.RowTemplate.Height = 24;
            this.dataGridViewTasks.Size = new System.Drawing.Size(930, 439);
            this.dataGridViewTasks.TabIndex = 0;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(1164, 63);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(100, 22);
            this.txtTaskName.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(1164, 114);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 22);
            this.txtDescription.TabIndex = 2;
            // 
            // comboBoxAssignee
            // 
            this.comboBoxAssignee.FormattingEnabled = true;
            this.comboBoxAssignee.Location = new System.Drawing.Point(1164, 169);
            this.comboBoxAssignee.Name = "comboBoxAssignee";
            this.comboBoxAssignee.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAssignee.TabIndex = 3;
            // 
            // dateTimePickerDeadline
            // 
            this.dateTimePickerDeadline.Location = new System.Drawing.Point(1164, 231);
            this.dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            this.dateTimePickerDeadline.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDeadline.TabIndex = 4;
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(1164, 293);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPriority.TabIndex = 5;
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Location = new System.Drawing.Point(1164, 435);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(94, 35);
            this.btnCreateTask.TabIndex = 6;
            this.btnCreateTask.Text = "Create";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1002, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Task Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1005, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1005, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Assignee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1005, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Deadline";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1008, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Priority";
            // 
            // btnViewReport
            // 
            this.btnViewReport.Location = new System.Drawing.Point(235, 494);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(75, 23);
            this.btnViewReport.TabIndex = 12;
            this.btnViewReport.Text = "Report";
            this.btnViewReport.UseVisualStyleBackColor = true;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click_1);
            // 
            // btnFinishTask
            // 
            this.btnFinishTask.Location = new System.Drawing.Point(830, 494);
            this.btnFinishTask.Name = "btnFinishTask";
            this.btnFinishTask.Size = new System.Drawing.Size(127, 23);
            this.btnFinishTask.TabIndex = 13;
            this.btnFinishTask.Text = "Finish Task";
            this.btnFinishTask.UseVisualStyleBackColor = true;
            this.btnFinishTask.Click += new System.EventHandler(this.btnFinishTask_Click);
            // 
            // checkBoxShowCompleted
            // 
            this.checkBoxShowCompleted.AutoSize = true;
            this.checkBoxShowCompleted.Location = new System.Drawing.Point(28, 497);
            this.checkBoxShowCompleted.Name = "checkBoxShowCompleted";
            this.checkBoxShowCompleted.Size = new System.Drawing.Size(172, 20);
            this.checkBoxShowCompleted.TabIndex = 14;
            this.checkBoxShowCompleted.Text = "Show Completed Tasks";
            this.checkBoxShowCompleted.UseVisualStyleBackColor = true;
            this.checkBoxShowCompleted.CheckedChanged += new System.EventHandler(this.checkBoxShowCompleted_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(0, 828);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(533, 60);
            this.label6.TabIndex = 15;
            this.label6.Text = "İf you have any problems please contact with your supervisor or admin\r\nFor inform" +
    "ation or contact: onurbaskan419@gmail.com\r\n\r\n";
            // 
            // LeaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1529, 888);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxShowCompleted);
            this.Controls.Add(this.btnFinishTask);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateTask);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.dateTimePickerDeadline);
            this.Controls.Add(this.comboBoxAssignee);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.dataGridViewTasks);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LeaderForm";
            this.Text = "BTTRFLY";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LeaderForm_FormClosing);
            this.Load += new System.EventHandler(this.LeaderForm_Load);
            this.Click += new System.EventHandler(this.btnViewReport_Click_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox comboBoxAssignee;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadline;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Button btnFinishTask;
        private System.Windows.Forms.CheckBox checkBoxShowCompleted;
        private System.Windows.Forms.Label label6;
    }
}