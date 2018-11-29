using System.Collections.Generic;
using BenefitsTracker.Data.Entities;

namespace BenefitsTracker.Data
{
    public interface IBenefitsTrackerRepository
    {
        void AddEmployee(Employee employee);
        IEnumerable<Employee> GetAllEmployees();
    }
}