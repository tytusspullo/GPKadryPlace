using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPKadryPlace.Model.Classes
{
    public class EmployeeSchedulePosition
    {
        public int IDEmployeeSchedulePosition { get; set; }
        public int EmployeeScheduleID { get; set; } // Foreign Key to EmployeeSchedule
        public int EmployeeID { get; set; } // Foreign Key to Employee
        public DateTime ForDate { get; set; }
        public int EmployeeAbsenteeismID { get; set; } // Foreign Key to EmployeeAbsenteeism
        public DateTime Hours { get; set; }

        // Navigation properties
        public EmployeeSchedule EmployeeSchedule { get; set; }
        public Employee Employee { get; set; }
        public EmployeeAbsenteeism EmployeeAbsenteeism { get; set; }
    }
}
