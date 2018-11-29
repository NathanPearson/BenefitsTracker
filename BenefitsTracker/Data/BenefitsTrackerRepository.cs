using BenefitsTracker.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenefitsTracker.Data
{
    public class BenefitsTrackerRepository : IBenefitsTrackerRepository
    {
        private readonly BenefitsTrackerContext _ctx;

        public BenefitsTrackerRepository(BenefitsTrackerContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _ctx.Employees
                .OrderBy(emp => emp.Name)
                .ToList();
        }

        public void AddEmployee(Employee employee)
        {
            _ctx.Employees.Add(employee);
            _ctx.SaveChanges();  
        }
    }
}
