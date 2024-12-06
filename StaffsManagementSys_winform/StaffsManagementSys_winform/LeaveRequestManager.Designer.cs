namespace StaffsManagementSys_winform
{
    partial class LeaveRequestManager
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
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonDeny = new System.Windows.Forms.Button();
            this.dataGridViewLeaveRequestList = new System.Windows.Forms.DataGridView();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.RequestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaveRequestList)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonAccept.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAccept.Location = new System.Drawing.Point(806, 495);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(90, 40);
            this.buttonAccept.TabIndex = 1;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = false;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonDeny
            // 
            this.buttonDeny.BackColor = System.Drawing.Color.Tomato;
            this.buttonDeny.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDeny.Location = new System.Drawing.Point(911, 495);
            this.buttonDeny.Name = "buttonDeny";
            this.buttonDeny.Size = new System.Drawing.Size(91, 40);
            this.buttonDeny.TabIndex = 2;
            this.buttonDeny.Text = "Deny";
            this.buttonDeny.UseVisualStyleBackColor = false;
            this.buttonDeny.Click += new System.EventHandler(this.buttonDeny_Click);
            // 
            // dataGridViewLeaveRequestList
            // 
            this.dataGridViewLeaveRequestList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewLeaveRequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeaveRequestList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RequestId,
            this.ColumnName,
            this.StartDate,
            this.EndDate,
            this.Reason,
            this.requestStatus});
            this.dataGridViewLeaveRequestList.Location = new System.Drawing.Point(5, 4);
            this.dataGridViewLeaveRequestList.Name = "dataGridViewLeaveRequestList";
            this.dataGridViewLeaveRequestList.RowHeadersWidth = 57;
            this.dataGridViewLeaveRequestList.RowTemplate.Height = 24;
            this.dataGridViewLeaveRequestList.Size = new System.Drawing.Size(997, 485);
            this.dataGridViewLeaveRequestList.TabIndex = 3;
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFilter.Location = new System.Drawing.Point(142, 495);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(90, 40);
            this.buttonFilter.TabIndex = 4;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = false;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Accepted",
            "Denied"});
            this.comboBoxStatus.Location = new System.Drawing.Point(5, 504);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStatus.TabIndex = 5;
            // 
            // RequestId
            // 
            this.RequestId.HeaderText = "RequestId";
            this.RequestId.MinimumWidth = 7;
            this.RequestId.Name = "RequestId";
            this.RequestId.Width = 140;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 7;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 140;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "StartDate";
            this.StartDate.MinimumWidth = 7;
            this.StartDate.Name = "StartDate";
            this.StartDate.Width = 140;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "EndDate";
            this.EndDate.MinimumWidth = 7;
            this.EndDate.Name = "EndDate";
            this.EndDate.Width = 140;
            // 
            // Reason
            // 
            this.Reason.HeaderText = "Reason";
            this.Reason.MinimumWidth = 7;
            this.Reason.Name = "Reason";
            this.Reason.Width = 140;
            // 
            // requestStatus
            // 
            this.requestStatus.HeaderText = "Request Status";
            this.requestStatus.MinimumWidth = 7;
            this.requestStatus.Name = "requestStatus";
            this.requestStatus.Width = 140;
            // 
            // LeaveRequestManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1014, 540);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.dataGridViewLeaveRequestList);
            this.Controls.Add(this.buttonDeny);
            this.Controls.Add(this.buttonAccept);
            this.Name = "LeaveRequestManager";
            this.Text = "LeaveRequest";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeaveRequestList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonDeny;
        private System.Windows.Forms.DataGridView dataGridViewLeaveRequestList;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestStatus;
    }
}