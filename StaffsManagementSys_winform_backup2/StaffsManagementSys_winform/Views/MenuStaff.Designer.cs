namespace StaffsManagementSys_winform.Views
{
    partial class MenuStaff
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
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnRoutine = new System.Windows.Forms.Button();
            this.btnDuty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalary
            // 
            this.btnSalary.Location = new System.Drawing.Point(32, 265);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(158, 51);
            this.btnSalary.TabIndex = 11;
            this.btnSalary.Text = "Salary";
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(32, 350);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(158, 47);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(32, 433);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 42);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(32, 179);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(158, 48);
            this.btnRequest.TabIndex = 8;
            this.btnRequest.Text = "Leave Request Form";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnRoutine
            // 
            this.btnRoutine.Location = new System.Drawing.Point(32, 104);
            this.btnRoutine.Name = "btnRoutine";
            this.btnRoutine.Size = new System.Drawing.Size(158, 47);
            this.btnRoutine.TabIndex = 7;
            this.btnRoutine.Text = "Routine";
            this.btnRoutine.UseVisualStyleBackColor = true;
            this.btnRoutine.Click += new System.EventHandler(this.btnRoutine_Click);
            // 
            // btnDuty
            // 
            this.btnDuty.Location = new System.Drawing.Point(32, 27);
            this.btnDuty.Name = "btnDuty";
            this.btnDuty.Size = new System.Drawing.Size(158, 45);
            this.btnDuty.TabIndex = 6;
            this.btnDuty.Text = "Duty";
            this.btnDuty.UseVisualStyleBackColor = true;
            this.btnDuty.Click += new System.EventHandler(this.btnDuty_Click);
            // 
            // MenuStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 509);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.btnRoutine);
            this.Controls.Add(this.btnDuty);
            this.Name = "MenuStaff";
            this.Text = "MenuStaff";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnRoutine;
        private System.Windows.Forms.Button btnDuty;
    }
}