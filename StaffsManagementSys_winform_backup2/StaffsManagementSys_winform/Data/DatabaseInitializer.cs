using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffsManagementSys_winform.Data
{
    public static class DatabaseInitializer
    {
        private static string connectionString;

        static DatabaseInitializer()
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "staff_management.db");
            connectionString = $"Data Source={dbPath};Version=3;";
        }


        /// <summary>
        /// Tạo bảng Staff trong cơ sở dữ liệu nếu chưa tồn tại.
        /// </summary>
        public static void CreateStaffTable()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Tạo bảng Staff
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
                        MessageBox.Show("Bảng Staff đã được tạo thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo bảng Staff: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Tạo bảng LeaveRequest trong cơ sở dữ liệu nếu chưa tồn tại.
        /// </summary>
        public static void CreateLeaveRequestTable()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Tạo bảng LeaveRequest
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
                        MessageBox.Show("Bảng LeaveRequest đã được tạo thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo bảng LeaveRequest: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Kiểm tra và tạo các bảng cơ sở dữ liệu nếu chưa tồn tại.
        /// </summary>
        public static void InitializeDatabase()
        {
            CreateStaffTable();
            CreateLeaveRequestTable();
        }


        /// <summary>
        /// Khởi tạo dữ liệu mẫu cho bảng Staff
        /// </summary>
        public static void CreateTestDataForStaff()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Thêm dữ liệu mẫu
                    string insertQuery = GenerateInsertQueryForStaff();

                    using (var command = new SQLiteCommand(insertQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Dữ liệu mẫu đã được thêm vào bảng Staff.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tạo dữ liệu mẫu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Xóa bảng Staff
        /// </summary>
        public static void DropStaffTable()
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Xóa bảng Staff
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

        /// <summary>
        /// Tạo dữ liệu mẫu cho bảng LeaveRequest
        /// </summary>
        public static void CreateTestDataForLeaveRequest()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Thêm dữ liệu mẫu
                    string insertQuery = GenerateInsertQueryForLeaveRequest();

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

        /// <summary>
        /// Xóa bảng LeaveRequest
        /// </summary>
        public static void DropLeaveRequestTable()
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

        // Hàm trả về câu lệnh SQL insert cho bảng Staff
        private static string GenerateInsertQueryForStaff()
        {
            return @"
                INSERT INTO Staff (Name, Phone, Address, Note)
                VALUES
                ('A', '12345', 'Hanoi', 'Test 1'),
                ('B', '22222', 'Binh Duong', 'Test 2'),
                ('C', '13579', 'Hanoi', 'Test 3'),
                ('D', '20245', 'Binh Duong', 'Test 4'),
                ('E', '55555', 'Lam Dong', 'Test 5'),
                ('F', '77777', 'Singapore', 'Test 6'),
                ('G', '33333', 'Binh Duong', 'Test 7'),
                ('H', '00000', 'TP HCM', 'Test 8');
            ";
        }

        // Hàm trả về câu lệnh SQL insert cho bảng LeaveRequest
        private static string GenerateInsertQueryForLeaveRequest()
        {
            return @"
                INSERT INTO LeaveRequest (Name, StartDate, EndDate, Reason)
                VALUES
                ('A', '2024-12-05', '2024-12-07', 'Travelling'),
                ('C', '2024-12-05', '2024-12-06', 'Relax Time'),
                ('D', '2024-12-06', '2024-12-06', 'Have problem'),
                ('H', '2024-12-07', '2024-12-08', 'No reason'),
                ('F', '2024-12-05', '2024-12-05', 'Unsleep'),
                ('G', '2024-12-06', '2024-12-06', 'Test');
            ";
        }
    }
}
