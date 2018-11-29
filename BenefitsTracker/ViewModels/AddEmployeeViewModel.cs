using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenefitsTracker.ViewModels
{
    public class AddEmployeeViewModel
    {
        //Emp name is required
        //All names must be at least 5 Chars Long
        //TODO Clarify business neeed for discount applies to first or last name or both
        //TODO Separate Last Names as well 

        [Required]
        [MinLength(5)]
        public string Name { get; set; }
        public int EmpCost { get; set; }

        public bool HasDependents { get; set; }              
        [MinLength(5)]
        public string FirstDependent { get; set; }        
        [MinLength(5)]
        public string SecondDependent { get; set; }
        [MinLength(5)]
        public string ThirdDependent { get; set; }
        [MinLength(5)]
        public string FourthDependent { get; set; }
        [MinLength(5)]
        public string FifthDependent { get; set; }
        [MinLength(5)]
        public string SixthDependent { get; set; }

        public int FirstDependentCost { get; set; }
        public int SecondDependentCost { get; set; }
        public int ThirdDependentCost { get; set; }
        public int FourthDependentCost { get; set; }
        public int FifthDependentCost { get; set; }
        public int SixthDependentCost { get; set; }
        public int TotalCosts { get; set; }
    }
}
