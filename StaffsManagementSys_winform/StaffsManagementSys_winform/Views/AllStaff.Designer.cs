namespace StaffsManagementSys_winform.Views
{
    partial class AllStaff
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
            this.textboxSearch = new System.Windows.Forms.TextBox();
            this.buttonWorking = new System.Windows.Forms.Button();
            this.buttonLeave = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonUpdateStaffQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxSearch
            // 
            this.textboxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textboxSearch.Location = new System.Drawing.Point(12, 7);
            this.textboxSearch.Name = "textboxSearch";
            this.textboxSearch.Size = new System.Drawing.Size(427, 27);
            this.textboxSearch.TabIndex = 0;
            // 
            // buttonWorking
            // 
            this.buttonWorking.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonWorking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonWorking.ForeColor = System.Drawing.Color.Transparent;
            this.buttonWorking.Location = new System.Drawing.Point(736, 1);
            this.buttonWorking.Name = "buttonWorking";
            this.buttonWorking.Size = new System.Drawing.Size(89, 39);
            this.buttonWorking.TabIndex = 1;
            this.buttonWorking.Text = "Working";
            this.buttonWorking.UseVisualStyleBackColor = false;
            this.buttonWorking.Click += new System.EventHandler(this.buttonWorking_Click);
            // 
            // buttonLeave
            // 
            this.buttonLeave.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonLeave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLeave.Location = new System.Drawing.Point(831, 1);
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.Size = new System.Drawing.Size(83, 39);
            this.buttonLeave.TabIndex = 4;
            this.buttonLeave.Text = "Leave";
            this.buttonLeave.UseVisualStyleBackColor = false;
            this.buttonLeave.Click += new System.EventHandler(this.buttonLeave_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.Silver;
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonQuit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonQuit.Location = new System.Drawing.Point(920, 1);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(83, 39);
            this.buttonQuit.TabIndex = 5;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(12, 507);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(83, 39);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnName,
            this.columnPhone,
            this.columnAddress,
            this.columnNote,
            this.ColumnStatus});
            this.dataGridViewStaff.Location = new System.Drawing.Point(12, 46);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.RowHeadersWidth = 57;
            this.dataGridViewStaff.RowTemplate.Height = 24;
            this.dataGridViewStaff.Size = new System.Drawing.Size(990, 455);
            this.dataGridViewStaff.TabIndex = 7;
            // 
            // columnId
            // 
            this.columnId.HeaderText = "ID";
            this.columnId.MinimumWidth = 7;
            this.columnId.Name = "columnId";
            this.columnId.Width = 140;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Name";
            this.columnName.MinimumWidth = 7;
            this.columnName.Name = "columnName";
            this.columnName.Width = 140;
            // 
            // columnPhone
            // 
            this.columnPhone.HeaderText = "Phone";
            this.columnPhone.MinimumWidth = 7;
            this.columnPhone.Name = "columnPhone";
            this.columnPhone.Width = 140;
            // 
            // columnAddress
            // 
            this.columnAddress.HeaderText = "Address";
            this.columnAddress.MinimumWidth = 7;
            this.columnAddress.Name = "columnAddress";
            this.columnAddress.Width = 140;
            // 
            // columnNote
            // 
            this.columnNote.HeaderText = "Note";
            this.columnNote.MinimumWidth = 7;
            this.columnNote.Name = "columnNote";
            this.columnNote.Width = 140;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.MinimumWidth = 7;
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.Width = 140;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch.Location = new System.Drawing.Point(460, 1);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(83, 39);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonUpdateStaffQuit
            // 
            this.buttonUpdateStaffQuit.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonUpdateStaffQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonUpdateStaffQuit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdateStaffQuit.Location = new System.Drawing.Point(762, 507);
            this.buttonUpdateStaffQuit.Name = "buttonUpdateStaffQuit";
            this.buttonUpdateStaffQuit.Size = new System.Drawing.Size(240, 39);
            this.buttonUpdateStaffQuit.TabIndex = 9;
            this.buttonUpdateStaffQuit.Text = "Update Staff Quit";
            this.buttonUpdateStaffQuit.UseVisualStyleBackColor = false;
            this.buttonUpdateStaffQuit.Click += new System.EventHandler(this.buttonUpdateStaffQuit_Click);
            // 
            // AllStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1014, 540);
            this.Controls.Add(this.buttonUpdateStaffQuit);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridViewStaff);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonLeave);
            this.Controls.Add(this.buttonWorking);
            this.Controls.Add(this.textboxSearch);
            this.Name = "AllStaff";
            this.Text = "AllStaff";
            this.Load += new System.EventHandler(this.AllStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxSearch;
        private System.Windows.Forms.Button buttonWorking;
        private System.Windows.Forms.Button buttonLeave;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNote;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.Button buttonUpdateStaffQuit;
    }
}