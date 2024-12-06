using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffsManagementSys_winform.Models
{
    public class LeaveRequest
    {
        public int Id { get; set; }
        public int SecurityStaffId { get; set; } // Reference to SecurityStaff
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; } // Pending, Approved, Declined
    }
}
