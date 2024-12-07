namespace StaffsManagementSys_winform.Views
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLeaveRequest = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonRoutine = new System.Windows.Forms.Button();
            this.buttonDuty = new System.Windows.Forms.Button();
            this.buttonAddStaff = new System.Windows.Forms.Button();
            this.buttonAllStaff = new System.Windows.Forms.Button();
            this.groupBoxPage = new System.Windows.Forms.GroupBox();
            this.groupBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxMenu.Controls.Add(this.button1);
            this.groupBoxMenu.Controls.Add(this.buttonLeaveRequest);
            this.groupBoxMenu.Controls.Add(this.buttonLogout);
            this.groupBoxMenu.Controls.Add(this.buttonRoutine);
            this.groupBoxMenu.Controls.Add(this.buttonDuty);
            this.groupBoxMenu.Controls.Add(this.buttonAddStaff);
            this.groupBoxMenu.Controls.Add(this.buttonAllStaff);
            this.groupBoxMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxMenu.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(200, 593);
            this.groupBoxMenu.TabIndex = 0;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Menu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salary";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonLeaveRequest
            // 
            this.buttonLeaveRequest.Location = new System.Drawing.Point(6, 310);
            this.buttonLeaveRequest.Name = "buttonLeaveRequest";
            this.buttonLeaveRequest.Size = new System.Drawing.Size(188, 50);
            this.buttonLeaveRequest.TabIndex = 6;
            this.buttonLeaveRequest.Text = "Leave Request";
            this.buttonLeaveRequest.UseVisualStyleBackColor = true;
            this.buttonLeaveRequest.Click += new System.EventHandler(this.buttonLeaveRequest_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(6, 537);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(188, 50);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "Log out";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonRoutine
            // 
            this.buttonRoutine.Location = new System.Drawing.Point(6, 240);
            this.buttonRoutine.Name = "buttonRoutine";
            this.buttonRoutine.Size = new System.Drawing.Size(188, 50);
            this.buttonRoutine.TabIndex = 4;
            this.buttonRoutine.Text = "Routine";
            this.buttonRoutine.UseVisualStyleBackColor = true;
            this.buttonRoutine.Click += new System.EventHandler(this.buttonRoutine_Click);
            // 
            // buttonDuty
            // 
            this.buttonDuty.Location = new System.Drawing.Point(6, 165);
            this.buttonDuty.Name = "buttonDuty";
            this.buttonDuty.Size = new System.Drawing.Size(188, 50);
            this.buttonDuty.TabIndex = 3;
            this.buttonDuty.Text = "Duty";
            this.buttonDuty.UseVisualStyleBackColor = true;
            this.buttonDuty.Click += new System.EventHandler(this.buttonDuty_Click);
            // 
            // buttonAddStaff
            // 
            this.buttonAddStaff.Location = new System.Drawing.Point(6, 93);
            this.buttonAddStaff.Name = "buttonAddStaff";
            this.buttonAddStaff.Size = new System.Drawing.Size(188, 50);
            this.buttonAddStaff.TabIndex = 2;
            this.buttonAddStaff.Text = "Add Staff";
            this.buttonAddStaff.UseVisualStyleBackColor = true;
            this.buttonAddStaff.Click += new System.EventHandler(this.buttonAddStaff_Click);
            // 
            // buttonAllStaff
            // 
            this.buttonAllStaff.Location = new System.Drawing.Point(6, 21);
            this.buttonAllStaff.Name = "buttonAllStaff";
            this.buttonAllStaff.Size = new System.Drawing.Size(188, 50);
            this.buttonAllStaff.TabIndex = 1;
            this.buttonAllStaff.Text = "All Staff";
            this.buttonAllStaff.UseVisualStyleBackColor = true;
            this.buttonAllStaff.Click += new System.EventHandler(this.buttonAllStaff_Click);
            // 
            // groupBoxPage
            // 
            this.groupBoxPage.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBoxPage.Location = new System.Drawing.Point(228, 13);
            this.groupBoxPage.Name = "groupBoxPage";
            this.groupBoxPage.Size = new System.Drawing.Size(1034, 592);
            this.groupBoxPage.TabIndex = 1;
            this.groupBoxPage.TabStop = false;
            this.groupBoxPage.Text = "Page";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1274, 617);
            this.Controls.Add(this.groupBoxPage);
            this.Controls.Add(this.groupBoxMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Management System";
            this.groupBoxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.Button buttonAllStaff;
        private System.Windows.Forms.Button buttonRoutine;
        private System.Windows.Forms.Button buttonDuty;
        private System.Windows.Forms.Button buttonAddStaff;
        private System.Windows.Forms.GroupBox groupBoxPage;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLeaveRequest;
        private System.Windows.Forms.Button button1;
    }
}

