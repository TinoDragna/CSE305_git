using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

using System.Data.SQLite;
using System.Data.SqlClient;

namespace StaffsManagementSys_winform
{
    public partial class Form1 : Form
    {
        private AllStaff allStaff;
        private AddStaff addStaff;
        private Routine routine;
        private Duty duty;
        private LeaveRequest leaveRequest;
        public Form1()
        {
            InitializeComponent();

            allStaff = new AllStaff();
            allStaff.TopLevel = false;
            allStaff.FormBorderStyle = FormBorderStyle.None;
            allStaff.Dock = DockStyle.Fill;

            addStaff = new AddStaff();
            addStaff.TopLevel = false;
            addStaff.FormBorderStyle = FormBorderStyle.None;
            addStaff.Dock = DockStyle.Fill;

            routine = new Routine();
            routine.TopLevel = false;
            routine.FormBorderStyle = FormBorderStyle.None;
            routine.Dock = DockStyle.Fill;

            duty = new Duty();
            duty.TopLevel = false;
            duty.FormBorderStyle = FormBorderStyle.None;
            duty.Dock = DockStyle.Fill;

            leaveRequest = new LeaveRequest();
            leaveRequest.TopLevel = false;
            leaveRequest.FormBorderStyle = FormBorderStyle.None;
            leaveRequest.Dock = DockStyle.Fill;

            groupBoxPage.Controls.Add(allStaff);
            groupBoxPage.Controls.Add(addStaff);
            groupBoxPage.Controls.Add(routine);
            groupBoxPage.Controls.Add(duty);
            groupBoxPage.Controls.Add(leaveRequest);
            allStaff.Show();
            addStaff.Hide();
            routine.Hide();
            duty.Hide();
            leaveRequest.Hide();
        }

        private void buttonAllStaff_Click(object sender, EventArgs e)
        {
            allStaff.Show();
            addStaff.Hide();
            routine.Hide();
            duty.Hide();
            leaveRequest.Hide();
        }

        private void buttonAddStaff_Click(object sender, EventArgs e)
        {
            addStaff.Show();
            allStaff.Hide();
            routine.Hide();
            duty.Hide();
            leaveRequest.Hide();
        }

        private void buttonRoutine_Click(object sender, EventArgs e)
        {
            routine.Show();
            allStaff.Hide();
            addStaff.Hide();
            duty.Hide() ;
            leaveRequest.Hide();
        }

        private void buttonDuty_Click(object sender, EventArgs e)
        {
            duty.Show();
            allStaff.Hide();
            addStaff.Hide();
            routine.Hide();
            leaveRequest.Hide();
        }

        private void buttonLeaveRequest_Click(object sender, EventArgs e)
        {
            leaveRequest.Show();
            duty.Hide();
            allStaff.Hide();
            addStaff.Hide();
            routine.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            ManagerLogin managerLogin = new ManagerLogin();
            managerLogin.Show();
        }
    }
}
