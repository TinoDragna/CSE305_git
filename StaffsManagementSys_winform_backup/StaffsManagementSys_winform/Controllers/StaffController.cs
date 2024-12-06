using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaffsManagementSys_winform.Models;

namespace StaffsManagementSys_winform.Controllers
{
    public class StaffController
    {
        private readonly string connectionString;

        public StaffController(string dbPath)
        {
            connectionString = $"Data Source={dbPath};Version=3;";
        }

        public void AddStaff(Staff staff)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                string query = "INSERT INTO Staff (Name, Phone, Address, Note, Status) VALUES (@Name, @Phone, @Address, @Note, 'Working')";
                using (var command = new SQLiteCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Name", staff.Name);
                    command.Parameters.AddWithValue("@Phone", staff.Phone ?? string.Empty);
                    command.Parameters.AddWithValue("@Address", staff.Address ?? string.Empty);
                    command.Parameters.AddWithValue("@Note", staff.Note ?? string.Empty);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Staff> GetAllStaff(string status = "", string searchText = "")
        {
            var staffList = new List<Staff>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Staff WHERE 1=1";

                if (!string.IsNullOrEmpty(status))
                {
                    query += " AND Status = @Status";
                }
                if (!string.IsNullOrEmpty(searchText))
                {
                    query += " AND (Name LIKE @SearchText OR Phone LIKE @SearchText OR Address LIKE @SearchText)";
                }

                using (var command = new SQLiteCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(status))
                        command.Parameters.AddWithValue("@Status", status);
                    if (!string.IsNullOrEmpty(searchText))
                        command.Parameters.AddWithValue("@SearchText", $"%{searchText}%");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            staffList.Add(new Staff
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Phone = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                Address = reader.IsDBNull(3) ? "" : reader.GetString(3),
                                Note = reader.IsDBNull(4) ? "" : reader.GetString(4),
                                Status = reader.IsDBNull(5) ? "Working" : reader.GetString(5)
                            });
                        }
                    }
                }
            }
            return staffList;
        }

        public void UpdateStaffStatus(int staffId, string status)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                string query = "UPDATE Staff SET Status = @Status WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@Id", staffId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteStaff(int staffId)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                string query = "DELETE FROM Staff WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Id", staffId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
