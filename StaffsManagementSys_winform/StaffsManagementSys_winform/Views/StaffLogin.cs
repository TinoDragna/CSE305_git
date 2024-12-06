using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffsManagementSys_winform.Views
{
    public partial class StaffLogin : Form
    {
        public StaffLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String account = txtUsername.Text;
            String password = txtPw.Text;

            if (AccountStaff.compareAccount(account, password))
            {
                this.Hide();
                MenuStaff menuStaff = new MenuStaff();
                menuStaff.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void StaffLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
