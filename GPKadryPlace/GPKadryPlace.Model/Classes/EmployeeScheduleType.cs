using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPKadryPlace.Model.Classes
{
    public class EmployeeScheduleType
    {
        public int IDEmployeeScheduleType { get; set; }
        public string Name { get; set; }
        public bool Available { get; set; } = true;
    }
}
