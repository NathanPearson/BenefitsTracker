using BenefitsTracker.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenefitsTracker.Data
{
    public class TrackerSeeder
    {
        private readonly BenefitsTrackerContext _ctx;
        private readonly IHostingEnvironment _hosting;

        public TrackerSeeder(BenefitsTrackerContext ctx, IHostingEnvironment hosting)
        {
            _ctx = ctx;
            _hosting = hosting;        
        }

        public void Seed()
        {
            _ctx.Database.EnsureCreated();

            if(!_ctx.Employees.Any())
            {
                var path = Path.Combine(_hosting.ContentRootPath, "Data/StarterData.json");
                var json = File.ReadAllText(path);
                var employees = JsonConvert.DeserializeObject<IEnumerable<Employee>>(json);
                _ctx.Employees.AddRange(employees);

                _ctx.SaveChanges();
            }
        }
    }
}
