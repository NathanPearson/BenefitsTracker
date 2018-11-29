﻿// <auto-generated />
using BenefitsTracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BenefitsTracker.Migrations
{
    [DbContext(typeof(BenefitsTrackerContext))]
    [Migration("20181129015517_FixEmpModel")]
    partial class FixEmpModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BenefitsTracker.Data.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeCost");

                    b.Property<string>("FifthDependent");

                    b.Property<int>("FifthDependentCost");

                    b.Property<string>("FirstDependent");

                    b.Property<int>("FirstDependentCost");

                    b.Property<string>("FourthDependent");

                    b.Property<int>("FourthDependentCost");

                    b.Property<bool>("HasDependents");

                    b.Property<string>("Name");

                    b.Property<string>("SecondDependent");

                    b.Property<int>("SecondDependentCost");

                    b.Property<string>("SixthDependent");

                    b.Property<int>("SixthDependentCost");

                    b.Property<string>("ThirdDependent");

                    b.Property<int>("ThirdDependentCost");

                    b.Property<int>("TotalCosts");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}