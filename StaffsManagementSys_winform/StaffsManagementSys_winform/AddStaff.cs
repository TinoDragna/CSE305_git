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

namespace StaffsManagementSys_winform
{
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            string address = textBoxAddress.Text.Trim();
            string note = textBoxNote.Text.Trim();

            if (!string.IsNullOrEmpty(name))
            {
                // Gọi phương thức thêm nhân viên
                AddNewStaff(name, phone, address, note);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!");
            }
        }

        private void AddNewStaff(string name, string phone, string address, string note)
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "staff_management.db");
            string connectionString = $"Data Source={dbPath};Version=3;";

            using (var connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Staff (Name, Phone, Address, Note) VALUES (@Name, @Phone, @Address, @Note)";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Note", note);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Nhân viên đã được thêm!");
                        this.DialogResult = DialogResult.OK; // Trả kết quả thành công
                        //this.Close(); // Đóng form sau khi thêm
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm nhân viên: {ex.Message}");
                }
            }
        }

        
    }
}
