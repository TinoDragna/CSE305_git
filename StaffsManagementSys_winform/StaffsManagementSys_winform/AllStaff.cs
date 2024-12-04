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

namespace StaffsManagementSys_winform
{
    public partial class AllStaff : Form
    {
        public AllStaff()
        {
            InitializeComponent();
        }

        private void AllStaff_Load(object sender, EventArgs e)
        {
            CreateDatabase(); // Đảm bảo bảng được tạo
            LoadAllStaff();
        }

        private void LoadAllStaff(string status = "", string searchText = "")
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "staff_management.db");
            string connectionString = $"Data Source={dbPath};Version=3;"; // Đảm bảo dbPath đã được xác định trước đó

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Tạo câu truy vấn với điều kiện động
                string query = "SELECT * FROM Staff WHERE 1=1"; // 1=1 để thêm các điều kiện dễ dàng

                // Thêm điều kiện trạng thái
                if (!string.IsNullOrEmpty(status))
                {
                    query += " AND status = @status";
                }

                // Thêm điều kiện tìm kiếm
                if (!string.IsNullOrEmpty(searchText))
                {
                    query += " AND (Name LIKE @searchText OR Phone LIKE @searchText OR Address LIKE @searchText)";
                }

                using (var command = new SQLiteCommand(query, connection))
                {
                    // Thêm tham số trạng thái nếu có
                    if (!string.IsNullOrEmpty(status))
                    {
                        command.Parameters.AddWithValue("@status", status);
                    }

                    // Thêm tham số tìm kiếm nếu có
                    if (!string.IsNullOrEmpty(searchText))
                    {
                        command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        // Xóa dữ liệu cũ khỏi danh sách hiển thị
                        dataGridViewStaff.Rows.Clear();

                        while (reader.Read())
                        {
                            // Lấy dữ liệu từ cơ sở dữ liệu
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            string phone = reader.IsDBNull(2) ? "" : reader.GetString(2);
                            string address = reader.IsDBNull(3) ? "" : reader.GetString(3);
                            string note = reader.IsDBNull(4) ? "" : reader.GetString(4);
                            string statusDB = reader.IsDBNull(5) ? "" : reader.GetString(5); // Giả định cột status ở vị trí 5

                            // Thêm dữ liệu vào DataGridView
                            dataGridViewStaff.Rows.Add(id, name, phone, address, note, statusDB);
                        }
                    }
                }
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddStaff formAddStaff = new AddStaff();
            if (formAddStaff.ShowDialog() == DialogResult.OK)
            {
                LoadAllStaff(); // Tải lại danh sách sau khi thêm nhân viên
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStaff.SelectedRows.Count > 0)
            {
                int staffId = (int)dataGridViewStaff.SelectedRows[0].Cells[0].Value; // Lấy ID của dòng được chọn
                DeleteStaff(staffId);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!");
            }
        }

        private void DeleteStaff(int staffId)
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "staff_management.db");
            string connectionString = $"Data Source={dbPath};Version=3;";

            using (var connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Staff WHERE Id = @Id";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", staffId);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Nhân viên đã được xóa!");
                        LoadAllStaff(); // Cập nhật danh sách sau khi xóa
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa nhân viên: {ex.Message}");
                }
            }
        }

        private void CreateDatabase()
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "staff_management.db");

            // Tạo chuỗi kết nối đến SQLite
            string connectionString = $"Data Source={dbPath}";

            using (var connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Mở kết nối
                    MessageBox.Show("Kết nối SQLite thành công!");

                    // Tạo bảng nếu chưa tồn tại
                    string createTableQuery = @"
                        CREATE TABLE IF NOT EXISTS Staff (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name TEXT NOT NULL,
                            Phone TEXT,
                            Address TEXT,
                            Note TEXT
                        );";

                    using (var command = new SQLiteCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Bảng Staff đã được tạo (nếu chưa tồn tại).");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
        }

        private void buttonWorking_Click(object sender, EventArgs e)
        {
            string searchText = textboxSearch.Text.Trim();
            LoadAllStaff("Working", searchText);
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            string searchText = textboxSearch.Text.Trim();
            LoadAllStaff("Leave", searchText);
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            string searchText = textboxSearch.Text.Trim();
            LoadAllStaff("Quit", searchText);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchText = textboxSearch.Text.Trim();
            LoadAllStaff("", searchText);
        }

        private void textboxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textboxSearch.Text.Trim();
            // Lấy trạng thái hiện tại
            string currentStatus = GetCurrentStatus(); // Ví dụ: "Working", "Leave", "Quit", hoặc "" cho "All"
            LoadAllStaff(currentStatus, searchText);
        }

        private string GetCurrentStatus()
        {
            if (!buttonWorking.Enabled) return "Working";
            if (!buttonLeave.Enabled) return "Leave";
            if (!buttonQuit.Enabled) return "Quit";
            return ""; // Trả về tất cả nếu không chọn trạng thái
        }

    }
}
