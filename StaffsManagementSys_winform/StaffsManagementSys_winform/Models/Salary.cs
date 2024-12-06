using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace StaffsManagementSys_winform.Models
{
    public class Salary
    {
        public int Id { get; set; }
        public int SecurityStaffId { get; set; } // References SecurityStaff
        public DateTime MonthYear { get; set; }
        public decimal Amount { get; set; }

        public void CalculateSalary(Staff staff)
        {
        }
    }
}
