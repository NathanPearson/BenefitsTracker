using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BenefitsTracker.Migrations
{
    public partial class ChangeEmpandDep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FifthDependent",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FifthDependentCost",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FirstDependent",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FirstDependentCost",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FourthDependent",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FourthDependentCost",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SecondDependent",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SecondDependentCost",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SixthDependent",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SixthDependentCost",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ThirdDependent",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ThirdDependentCost",
                table: "Employees");

            migrationBuilder.CreateTable(
                name: "Dependents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Cost = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dependents_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dependents_EmployeeId",
                table: "Dependents",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dependents");

            migrationBuilder.AddColumn<string>(
                name: "FifthDependent",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FifthDependentCost",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FirstDependent",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FirstDependentCost",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FourthDependent",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FourthDependentCost",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SecondDependent",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecondDependentCost",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SixthDependent",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SixthDependentCost",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ThirdDependent",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ThirdDependentCost",
                table: "Employees",
                nullable: false,
                defaultValue: 0);
        }
    }
}
