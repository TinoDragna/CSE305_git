using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffsManagementSys_winform.Models
{
    public class Routine
    {
        public int Id { get; set; }
        public List<Duty> Duties { get; set; }

        public Routine()
        {
            Duties = new List<Duty>();
        }

        public void AddDuty(Duty duty)
        {
            Duties.Add(duty);
        }

        public void RemoveDuty(Duty duty)
        {
            Duties.Remove(duty);
        }

        public string GetRoutineSummary()
        {
            return $"Routine ID: {Id}, Total Duties: {Duties.Count}";
        }
    }
}
