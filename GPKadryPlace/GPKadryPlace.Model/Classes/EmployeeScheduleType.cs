using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPKadryPlace.Model
{
    public class EmployeeScheduleType
    {

        public EmployeeScheduleType(int IDEmployeeScheduleType ,string name ,bool avilable) 
        { 
            this.IDEmployeeScheduleType = IDEmployeeScheduleType;
            this.Name = name;  
            this.Available = avilable;
        }
        public int IDEmployeeScheduleType { get; set; }
        public string Name { get; set; }
        public bool Available { get; set; } = true;
    }
}
