using BenefitsTracker.Data;
using BenefitsTracker.Data.Entities;
using BenefitsTracker.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenefitsTracker.Controllers
{
    public class AppController : Controller
    {
        private readonly IBenefitsTrackerRepository _repo;
        private readonly BenefitsTrackerContext _ctx;


        public AppController(IBenefitsTrackerRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Review()
        {
            var results = _repo.GetAllEmployees();
               
            return View(results);
        }

        [HttpGet("addemployee")]
        public IActionResult AddEmployee()
        {
            //ViewBag.Title = "Add Employees";
            return View();
        }

        [HttpPost("addemployee")]
        public IActionResult AddEmployee(Employee emp)
        {
            if(ModelState.IsValid)
            {
                emp.TotalCosts = 0;
                //TODO Refactor
                //TODO REVIEW FOR cleaner implementation
                if (Char.ToLower(emp.Name[0]).Equals('a'))
                {
                    emp.EmployeeCost = 900;
                }
                else
                {
                    emp.EmployeeCost = 1000;
                }

                emp.TotalCosts = emp.EmployeeCost;
                
                //Does EMP have dependents
                //TODO review for cleaner solution
                if (emp.HasDependents)
                {
                    if (emp.FirstDependent != null)
                    {
                        if (Char.ToLower(emp.FirstDependent[0]).Equals('a'))
                        {
                            emp.FirstDependentCost = 450;
                        }
                        else
                        {
                            emp.FirstDependentCost = 500;
                        }
                        emp.TotalCosts += emp.FirstDependentCost;
                    }//end first                    

                    if (emp.SecondDependent != null)
                    {
                        if (Char.ToLower(emp.SecondDependent[0]).Equals('a'))
                        {
                            emp.SecondDependentCost = 450;
                        }
                        else
                        {
                            emp.SecondDependentCost = 500;
                        }
                        emp.TotalCosts += emp.SecondDependentCost;
                    }//end second

                    if (emp.ThirdDependent != null)
                    {
                        if (Char.ToLower(emp.ThirdDependent[0]).Equals('a'))
                        {
                            emp.ThirdDependentCost = 450;
                        }
                        else
                        {
                            emp.ThirdDependentCost = 500;
                        }
                        emp.TotalCosts += emp.ThirdDependentCost;
                    }//end third

                    if (emp.FourthDependent != null)
                    {
                        if (Char.ToLower(emp.FourthDependent[0]).Equals('a'))
                        {
                            emp.FourthDependentCost = 450;
                        }
                        else
                        {
                            emp.FourthDependentCost = 500;
                        }
                        emp.TotalCosts += emp.FourthDependentCost;
                    }//end fourth

                    if (emp.FifthDependent != null)
                    {
                        if (Char.ToLower(emp.FifthDependent[0]).Equals('a'))
                        {
                            emp.FifthDependentCost = 450;
                        }
                        else
                        {
                            emp.FifthDependentCost = 500;
                        }
                        emp.TotalCosts += emp.FifthDependentCost;
                    }//end fifth

                    if (emp.SixthDependent != null)
                    {
                        if (Char.ToLower(emp.SixthDependent[0]).Equals('a'))
                        {
                            emp.SixthDependentCost = 450;
                        }
                        else
                        {
                            emp.SixthDependentCost = 500;
                        }
                        emp.TotalCosts += emp.SixthDependentCost;
                    }//end sixth
                }//end has dependents if
                else
                {
                    emp.FirstDependentCost = 0;
                    emp.SecondDependentCost = 0;
                    emp.ThirdDependentCost = 0;
                    emp.FourthDependentCost = 0;
                    emp.FifthDependentCost = 0;
                    emp.SixthDependentCost = 0;
                }               
                
                emp.Salary = 52000;//2000 * 26
                emp.AfterDeductionSalary = emp.Salary - emp.TotalCosts;                                

                _repo.AddEmployee(emp);

                ViewBag.UserMessage = "Successfully added employee";
                ModelState.Clear();
            }           
            
            return View();
        }

    }
}
