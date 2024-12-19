using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPKadryPlace.Model;

namespace GPKadryPlace.ViewModel.ViewModels
{
    public class EmployeeAbsenteeismViewModel: BaseViewModel
    {
        private EmployeeAbsenteeisms employeeAbsenteeisms = null;
        public EmployeeAbsenteeismViewModel(string connectionString)
        {
            this.employeeAbsenteeisms = new EmployeeAbsenteeisms(connectionString);
        }
    }
}
