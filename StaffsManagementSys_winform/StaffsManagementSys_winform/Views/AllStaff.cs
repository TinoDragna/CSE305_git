using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StaffsManagementSys_winform.Controllers;

namespace StaffsManagementSys_winform.Views
{
    public partial class AllStaff : Form
    {
        private readonly StaffController _staffController;

        public AllStaff()
        {
            InitializeComponent();
            _staffController = new StaffController("staff_management.db");
        }

        private void AllStaff_Load(object sender, EventArgs e)
        {
            LoadAllStaff();
        }

        private void LoadAllStaff(string status = "", string searchText = "")
        {
            var staffList = _staffController.GetAllStaff(status, searchText);
            dataGridViewStaff.Rows.Clear();

            foreach (var staff in staffList)
            {
                dataGridViewStaff.Rows.Add(staff.Id, staff.Name, staff.Phone, staff.Address, staff.Note, staff.Status);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchText = textboxSearch.Text.Trim();
            LoadAllStaff("", searchText); // Tìm kiếm với mọi trạng thái
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddStaff formAddStaff = new AddStaff();
            if (formAddStaff.ShowDialog() == DialogResult.OK)
            {
                LoadAllStaff(); // Cập nhật danh sách sau khi thêm nhân viên
            }
        }

        private void buttonWorking_Click(object sender, EventArgs e)
        {
            string searchText = textboxSearch.Text.Trim();
            LoadAllStaff("Working", searchText); // Hiển thị danh sách nhân viên có trạng thái "Working"
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            string searchText = textboxSearch.Text.Trim();
            LoadAllStaff("Leave", searchText); // Hiển thị danh sách nhân viên có trạng thái "Leave"
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            string searchText = textboxSearch.Text.Trim();
            LoadAllStaff("Quit", searchText); // Hiển thị danh sách nhân viên có trạng thái "Quit"
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStaff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a staff to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int staffId = Convert.ToInt32(dataGridViewStaff.SelectedRows[0].Cells[0].Value);
            _staffController.DeleteStaff(staffId);
            LoadAllStaff(); // Cập nhật lại danh sách sau khi xóa nhân viên
        }

        private void buttonUpdateStaffQuit_Click(object sender, EventArgs e)
        {
            if (dataGridViewStaff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a staff to update status.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int staffId = Convert.ToInt32(dataGridViewStaff.SelectedRows[0].Cells[0].Value);
            _staffController.UpdateStaffStatus(staffId, "Quit");
            LoadAllStaff(); // Cập nhật lại danh sách sau khi cập nhật trạng thái
        }

        private void textboxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textboxSearch.Text.Trim();
            LoadAllStaff("", searchText); // Tìm kiếm khi người dùng nhập vào textbox
        }
    }
}