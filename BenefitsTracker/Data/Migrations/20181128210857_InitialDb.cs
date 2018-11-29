using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BenefitsTracker.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    HasDependents = table.Column<bool>(nullable: false),
                    FirstDependent = table.Column<string>(nullable: true),
                    SecondDependent = table.Column<string>(nullable: true),
                    ThirdDependent = table.Column<string>(nullable: true),
                    FourthDependent = table.Column<string>(nullable: true),
                    FifthDependent = table.Column<string>(nullable: true),
                    SixthDependent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
