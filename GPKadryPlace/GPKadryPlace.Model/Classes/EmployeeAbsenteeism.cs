using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPKadryPlace.Model
{
    public class EmployeeAbsenteeism
    {
        public int IDEmployeeAbsenteeism { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        public bool Available { get; set; } = true;
    }
}
