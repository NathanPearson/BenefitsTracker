using BenefitsTracker.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenefitsTracker.Data
{
    public interface IBenefitsRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        void AddEmployee(Employee employee);
    }
}
