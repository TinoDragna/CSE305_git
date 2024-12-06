
using StaffsManagementSys_winform.Models;
using System;

namespace StaffsManagementSys_winform.Demo
{
    public static class LeaveRequestDemo
    {
        public static void RunDemo()
        {
            // Tạo yêu cầu nghỉ phép
            var leaveRequest = new LeaveRequest
            {
                Id = 1,
                SecurityStaffId = 1001,
                StartDate = DateTime.Now.AddDays(1),
                EndDate = DateTime.Now.AddDays(3),
                Reason = "Vacation",
                Status = "Pending"
            };

            // Hiển thị thông tin ban đầu
            Console.WriteLine($"LeaveRequest ID: {leaveRequest.Id}, Status: {leaveRequest.Status}");

            // Phê duyệt yêu cầu
            leaveRequest.Accept();
            Console.WriteLine($"Updated Status: {leaveRequest.Status}");
        }
    }
}
