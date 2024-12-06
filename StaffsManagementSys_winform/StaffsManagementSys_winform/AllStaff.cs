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

namespace StaffsManagementSys_winform
{
    public partial class AllStaff : Form
    {
        string connectionString;

        public AllStaff()
        {
            InitializeComponent();
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "staff_management.db");
            connectionString = $"Data Source={dbPath};Version=3;"; // Đảm bảo dbPath đã được xác định trước đó
        }

        private void AllStaff_Load(object sender, EventArgs e)
        {
            //DropStaffTable();
            CreateDatabase(); // Đảm bảo bảng được tạo
            //CreateTestData();
            LoadAllStaff();
        }

        private void LoadAllStaff(string status = "", string searchText = "")
        {
            
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

        private void UpdateStaffQuit(int staffId)
        {

            using (var connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Cập nhật trạng thái nhân viên thành "Quit"
                    string updateQuery = "UPDATE Staff SET Status = 'Quit' WHERE Id = @Id";
                    using (var command = new SQLiteCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", staffId);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Trạng thái nhân viên đã được cập nhật thành 'Quit'!");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhân viên với Id đã cho.");
                        }
                    }

                    LoadAllStaff(); // Cập nhật danh sách sau khi thay đổi trạng thái
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật trạng thái nhân viên: {ex.Message}");
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
                            Note TEXT,
                            Status TEXT DEFAULT 'Working'
                        );";

                    using (var command = new SQLiteCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Bảng Staff đã được tạo.");
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

        private void buttonUpdateStaffQuit_Click(object sender, EventArgs e)
        {
            if (dataGridViewStaff.SelectedRows.Count > 0)
            {
                int staffId = (int)dataGridViewStaff.SelectedRows[0].Cells[0].Value; // Lấy ID của dòng được chọn
                UpdateStaffQuit(staffId);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteStaff();
        }

        private void DeleteStaff()
        {
            if (dataGridViewStaff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a staff to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected staff?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int staffId = Convert.ToInt32(dataGridViewStaff.SelectedRows[0].Cells["Id"].Value);

                // Đường dẫn tới database
                //string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "staff_management.db");
                //string connectionString = $"Data Source={dbPath};Version=3;";

                using (var connection = new SQLiteConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        // Câu lệnh để xóa nhân viên khỏi cơ sở dữ liệu
                        string query = "DELETE FROM Staff WHERE Id = @Id";
                        using (var command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Id", staffId);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Staff deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadAllStaff(); // Cập nhật danh sách sau khi xóa
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete staff. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }




        /// <summary>
        /// test
        /// </summary>

        private void CreateTestData()
        {
            //string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "staff_management.db");
            //string connectionString = $"Data Source={dbPath};Version=3;";

            using (var connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Thêm dữ liệu mẫu

                    string insertQuery = test1();

                    using (var command = new SQLiteCommand(insertQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Dữ liệu mẫu đã được thêm vào bảng LeaveRequest.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tạo dữ liệu mẫu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public String test1()
        {
            string insertQuery = @"
                        INSERT INTO Staff (Name, Phone, Address, Note)
                        VALUES
                        ('A', '12345', 'hanoi', 'test 1'),
                        ('B', '22222', 'binhduong', 'test 2'),
                        ('C', '13579', 'hanoi', 'test 3'),
                        ('D', '20245', 'binhduong', 'test 4'),
                        ('E', '55555', 'lam dong', 'test 5'),
                        ('F', '77777', 'singapore', 'test 6'),
                        ('G', '33333', 'binhduong', 'test 7'),
                        ('H', '00000', 'tp hcm', 'test 8');
                    ";
            return insertQuery;
        }

        private void DropStaffTable()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Xóa bảng LeaveRequest
                    string dropTableQuery = "DROP TABLE IF EXISTS Staff;";

                    using (var command = new SQLiteCommand(dropTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Bảng Staff đã được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa bảng Staff: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}