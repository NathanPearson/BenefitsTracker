using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenefitsTracker.Data.Entities
{
    public class Dependents
    {
        public int Id { get; set; }
        public string Name { get; set;  }
        public int Cost { get; set; }
        
        public Employee Employee { get; set; }
    }
}
