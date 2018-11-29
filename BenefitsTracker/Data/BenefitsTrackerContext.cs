using BenefitsTracker.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenefitsTracker.Data
{
    public class BenefitsTrackerContext : DbContext
    {
        public BenefitsTrackerContext(DbContextOptions<BenefitsTrackerContext> options): base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>()
                .HasData();
        }
    }
}
