using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffsManagementSys_winform.Models
{
    public class Duty
    {
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int PlaceId { get; set; } // References Place
        public int SecurityStaffId { get; set; } // References SecurityStaff

        public string GetDutyDescription()
        {
            return $"Duty on {Date.ToShortDateString()} " +
                $"from {StartTime.ToShortTimeString()} " +
                $"to {EndTime.ToShortTimeString()} " +
                $"at Place ID {PlaceId}.";
        }
    }
}
