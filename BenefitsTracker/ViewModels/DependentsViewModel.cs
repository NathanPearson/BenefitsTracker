using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenefitsTracker.ViewModels
{
    public class DependentsViewModel
    {
        [MinLength(5)]
        public string DependentName { get; set; }
        public int DependentCost { get; set; }
    }
}
