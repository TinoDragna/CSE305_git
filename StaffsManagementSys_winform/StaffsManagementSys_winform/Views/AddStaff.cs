using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using StaffsManagementSys_winform.Controllers;
using StaffsManagementSys_winform.Models;

namespace StaffsManagementSys_winform
{
    public partial class AddStaff : Form
    {
        private readonly StaffController _staffController;

        public AddStaff()
        {
            InitializeComponent();
            _staffController = new StaffController("staff_management.db");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            string address = textBoxAddress.Text.Trim();
            string note = textBoxNote.Text.Trim();

            if (!string.IsNullOrEmpty(name))
            {
                var newStaff = new Staff { Name = name, Phone = phone, Address = address, Note = note };
                _staffController.AddStaff(newStaff);
                MessageBox.Show("Nhân viên đã được thêm thành công!");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!");
            }
        }
    }

}
