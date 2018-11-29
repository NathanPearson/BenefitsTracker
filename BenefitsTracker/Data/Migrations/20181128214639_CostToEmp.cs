using Microsoft.EntityFrameworkCore.Migrations;

namespace BenefitsTracker.Migrations
{
    public partial class CostToEmp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpCost",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FifthDependentCost",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstDependentCost",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FourthDependentCost",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondDependentCost",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SixthDependentCost",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdDependentCost",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpCost",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FifthDependentCost",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FirstDependentCost",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FourthDependentCost",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SecondDependentCost",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SixthDependentCost",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ThirdDependentCost",
                table: "Employees");
        }
    }
}
