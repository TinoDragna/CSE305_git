using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace StaffsManagementSys_winform
{
    public partial class LeaveRequestManager : Form
    {
        private string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "staff_management.db");
        private string connectionString;

        public LeaveRequestManager()
        {

            InitializeComponent();
            connectionString = $"Data Source={dbPath};Version=3;";

            //DropLeaveRequestTable(); // Xóa bảng cũ
            CreateDatabase(); // Tạo bảng mới
            //CreateTestData(); // Thêm dữ liệu mẫu

            LoadLeaveRequests(); // Tải dữ liệu
            comboBoxStatus.SelectedIndex = 0;

        }

        private void CreateDatabase()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string createTableQuery = @"
                        CREATE TABLE IF NOT EXISTS LeaveRequest (
                            RequestId INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name TEXT NOT NULL,
                            StartDate DATE NOT NULL,
                            EndDate DATE NOT NULL,
                            Reason TEXT,
                            RequestStatus TEXT DEFAULT 'Pending'
                        );";

                    using (var command = new SQLiteCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("LeaveRequest table created or already exists.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LoadLeaveRequests(string requestStatus = "All")
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Truy vấn lấy dữ liệu từ LeaveRequest
                    string query = "SELECT * FROM LeaveRequest";
                    if (requestStatus != "All")
                    {
                        query += " WHERE RequestStatus = @requestStatus";
                    }

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        if (requestStatus != "All")
                        {
                            command.Parameters.AddWithValue("@requestStatus", requestStatus);
                        }

                        using (var reader = command.ExecuteReader())
                        {
                            dataGridViewLeaveRequestList.Rows.Clear(); // Xóa dữ liệu cũ

                            while (reader.Read())
                            {
                                dataGridViewLeaveRequestList.Rows.Add(
                                    reader["RequestId"],
                                    reader["Name"],
                                    reader["StartDate"],
                                    reader["EndDate"],
                                    reader["Reason"],
                                    reader["RequestStatus"]
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading leave requests: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateLeaveRequestStatus(string newStatus)
        {
            if (dataGridViewLeaveRequestList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a leave request to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy thông tin từ dòng được chọn
                int requestId = Convert.ToInt32(dataGridViewLeaveRequestList.SelectedRows[0].Cells["RequestId"].Value);
                string staffName = dataGridViewLeaveRequestList.SelectedRows[0].Cells["ColumnName"].Value.ToString();
                DateTime startDate = Convert.ToDateTime(dataGridViewLeaveRequestList.SelectedRows[0].Cells["StartDate"].Value);
                DateTime endDate = Convert.ToDateTime(dataGridViewLeaveRequestList.SelectedRows[0].Cells["EndDate"].Value);

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // **Cập nhật trạng thái yêu cầu nghỉ phép**
                    string updateRequestQuery = "UPDATE LeaveRequest " +
                        "SET RequestStatus = @requestStatus " +
                        "WHERE RequestId = @requestId";

                    using (var command = new SQLiteCommand(updateRequestQuery, connection))
                    {
                        command.Parameters.AddWithValue("@requestStatus", newStatus);
                        command.Parameters.AddWithValue("@requestId", requestId);
                        command.ExecuteNonQuery();
                    }

                    // **Cập nhật trạng thái của nhân viên**
                    if (newStatus == "Accepted")
                    {
                        // Kiểm tra xem ngày hiện tại có nằm trong khoảng thời gian nghỉ phép không
                        DateTime today = DateTime.Today;
                        if (today >= startDate && today <= endDate)
                        {
                            string updateStaffQuery = "UPDATE Staff SET Status = 'Leave' WHERE Name = @name";

                            using (var command = new SQLiteCommand(updateStaffQuery, connection))
                            {
                                command.Parameters.AddWithValue("@name", staffName);
                                command.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show("The leave request cannot be accepted today as it is not within the designated leave period.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Không cập nhật trạng thái của nhân viên nếu không đúng ngày
                        }
                    }
                    else if (newStatus == "Denied")
                    {
                        string checkQuery = @"
                    SELECT COUNT(*) 
                    FROM LeaveRequest 
                    WHERE Name = @name AND RequestStatus = 'Accepted' 
                    AND StartDate <= @today AND EndDate >= @today;
                ";

                        using (var command = new SQLiteCommand(checkQuery, connection))
                        {
                            command.Parameters.AddWithValue("@name", staffName);
                            command.Parameters.AddWithValue("@today", DateTime.Now.Date);

                            int count = Convert.ToInt32(command.ExecuteScalar());

                            if (count == 0)
                            {
                                string resetStaffQuery = "UPDATE Staff SET Status = 'Working' WHERE Name = @name";

                                using (var resetCommand = new SQLiteCommand(resetStaffQuery, connection))
                                {
                                    resetCommand.Parameters.AddWithValue("@name", staffName);
                                    resetCommand.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    MessageBox.Show($"Leave request has been {newStatus.ToLower()} successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLeaveRequests(); // Tải lại danh sách yêu cầu nghỉ phép
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating leave request status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonAccept_Click(object sender, EventArgs e)
        {
            UpdateLeaveRequestStatus("Accepted");
        }

        private void buttonDeny_Click(object sender, EventArgs e)
        {
            UpdateLeaveRequestStatus("Denied");
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            string selectedStatus = comboBoxStatus.SelectedItem?.ToString();
            LoadLeaveRequests(selectedStatus);
        }










        /// <summary>
        /// test
        /// </summary>

        private void CreateTestData()
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "staff_management.db");
            string connectionString = $"Data Source={dbPath};Version=3;";

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
                INSERT INTO LeaveRequest (Name, StartDate, EndDate, Reason)
                VALUES
                ('A', '2024-12-05', '2024-12-07', 'Travelling'),
                ('C', '2024-12-05', '2024-12-06', 'Relax Time'),
                ('D', '2024-12-06', '2024-12-06', 'Have problem'),
                ('H', '2024-12-07', '2024-12-08', 'No reason'),
                ('F', '2024-12-05', '2024-12-05', 'Unsleep'),
                ('G', '2024-12-06', '2024-12-06', 'Test');
            ";
            return insertQuery;
        }




        private void DropLeaveRequestTable()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Xóa bảng LeaveRequest
                    string dropTableQuery = "DROP TABLE IF EXISTS LeaveRequest;";

                    using (var command = new SQLiteCommand(dropTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Bảng LeaveRequest đã được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa bảng LeaveRequest: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}