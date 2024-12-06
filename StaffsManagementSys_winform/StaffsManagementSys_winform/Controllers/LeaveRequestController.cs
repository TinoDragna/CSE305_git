using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaffsManagementSys_winform.Models;

namespace StaffsManagementSys_winform.Controllers
{
    public class LeaveRequestController
    {
        private readonly string connectionString;

        public LeaveRequestController(string dbPath)
        {
            connectionString = $"Data Source={dbPath};Version=3;";
        }

        public List<LeaveRequest> GetLeaveRequests(string status = "All")
        {
            var requests = new List<LeaveRequest>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM LeaveRequest";
                if (status != "All")
                {
                    query += " WHERE Status = @Status";
                }

                using (var command = new SQLiteCommand(query, connection))
                {
                    if (status != "All")
                    {
                        command.Parameters.AddWithValue("@Status", status);
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            requests.Add(new LeaveRequest
                            {
                                Id = reader.GetInt32(0),
                                SecurityStaffId = reader.GetInt32(1),
                                StartDate = reader.GetDateTime(2),
                                EndDate = reader.GetDateTime(3),
                                Reason = reader.GetString(4),
                                Status = reader.GetString(5)
                            });
                        }
                    }
                }
            }
            return requests;
        }

        public void UpdateRequestStatus(int requestId, string newStatus)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE LeaveRequest SET Status = @Status WHERE Id = @RequestId";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", newStatus);
                    command.Parameters.AddWithValue("@RequestId", requestId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
