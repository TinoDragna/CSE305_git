using StaffsManagementSys_winform.Models;
using System;

namespace StaffsManagementSys_winform.Demo_console
{
    public static class RoutineDemo
    {
        public static void RunDemo()
        {
            // Tạo Routine mới
            var routine = new Routine { Id = 1 };

            // Tạo ca làm việc và thêm vào Routine
            var duty = new Duty
            {
                Date = DateTime.Now,
                StartTime = DateTime.Now.AddHours(-1),
                EndTime = DateTime.Now.AddHours(2),
                PlaceId = 101,
                SecurityStaffId = 1001
            };

            routine.AddDuty(duty);

            // Hiển thị thông tin Routine
            Console.WriteLine("Routine Summary:");
            Console.WriteLine(routine.GetRoutineSummary());
        }
    }
}
