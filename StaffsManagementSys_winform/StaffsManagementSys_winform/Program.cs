using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StaffsManagementSys_winform.Data;
using StaffsManagementSys_winform.Demo;
using StaffsManagementSys_winform.Demo_console;
using StaffsManagementSys_winform.Views;

namespace StaffsManagementSys_winform
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //RoutineDemo.RunDemo();
            //DutyDemo.RunDemo();
            //LeaveRequestDemo.RunDemo();

            //Console.WriteLine();

            DatabaseInitializer.DropStaffTable();
            DatabaseInitializer.DropLeaveRequestTable();

            DatabaseInitializer.InitializeDatabase(); // Khởi tạo database nếu chưa có

            DatabaseInitializer.CreateTestDataForStaff();
            DatabaseInitializer.CreateTestDataForLeaveRequest();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
