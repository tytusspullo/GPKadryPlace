using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPKadryPlace.Model
{
    public class EmployeeSchedule
    {
        public int IDEmployeeSchedule { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int EmployeeScheduleTypeID { get; set; } // Foreign Key to EmployeeScheduleType
        public string NameOfEmployeeGroup { get; set; }
        public bool Available { get; set; } = true;

        // Collection of related schedule positions
        public List<EmployeeSchedulePosition> EmployeeSchedulePositions { get; set; } = new List<EmployeeSchedulePosition>();
    }
}
