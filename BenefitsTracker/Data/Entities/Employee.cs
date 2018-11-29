using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenefitsTracker.Data.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EmployeeCost { get; set; } 
        public bool HasDependents { get; set; }

        //attempted child class ran out of time to implement fully 
        //reverted to working solution and MVP
        //public ICollection<Dependents> Dependents { get; set; }
        public string FirstDependent { get; set; }
        public string SecondDependent { get; set; }        
        public string ThirdDependent { get; set; }       
        public string FourthDependent { get; set; }      
        public string FifthDependent { get; set; }
        public string SixthDependent { get; set; }
        public int FirstDependentCost { get; set; }
        public int SecondDependentCost { get; set; }
        public int ThirdDependentCost { get; set; }
        public int FourthDependentCost { get; set; }
        public int FifthDependentCost { get; set; }
        public int SixthDependentCost { get; set; }
        public int TotalCosts { get; set; }
        public int Salary { get; set; }
        public int AfterDeductionSalary { get; set; }        
    }
}
