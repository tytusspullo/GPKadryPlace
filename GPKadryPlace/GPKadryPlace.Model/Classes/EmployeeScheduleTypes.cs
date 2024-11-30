using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPKadryPlace.Model
{
    public class EmployeeScheduleTypes:List<EmployeeScheduleType>
    {
        public EmployeeScheduleTypes() 
        {
            this.Add(new EmployeeScheduleType(1, "Planowany" ,true));
            this.Add(new EmployeeScheduleType(2, "Wykonania", true));
        }

    }
}
