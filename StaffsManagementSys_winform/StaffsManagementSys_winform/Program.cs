using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StaffsManagementSys_winform.Data;

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
            
            DatabaseInitializer.DropStaffTable();
            DatabaseInitializer.DropLeaveRequestTable();

            DatabaseInitializer.InitializeDatabase(); // Khởi tạo database nếu chưa có

            DatabaseInitializer.CreateTestDataForStaff();
            DatabaseInitializer.CreateTestDataForLeaveRequest();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ManagerLogin());
        }
    }
}
