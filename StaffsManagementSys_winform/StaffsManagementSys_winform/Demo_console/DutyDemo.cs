using StaffsManagementSys_winform.Models;
using System;


namespace StaffsManagementSys_winform.Demo_console
{
    public static class DutyDemo
    {
        public static void RunDemo()
        {
            // Tạo ca làm việc
            var duty = new Duty
            {
                Date = DateTime.Now,
                StartTime = DateTime.Now.AddHours(-1),
                EndTime = DateTime.Now.AddHours(2),
                PlaceId = 101,
                SecurityStaffId = 1001
            };

            // Hiển thị thông tin ca làm việc
            Console.WriteLine("Duty Info:");
            Console.WriteLine(duty.GetDutyDescription());
        }
    }
}
