using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Afkar.Migrations
{
    public partial class AddLoans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoansRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MonthlyIncome = table.Column<float>(type: "real", nullable: false),
                    LoanAmount = table.Column<int>(type: "int", nullable: false),
                    LoanDuration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoansRequests", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoansRequests");
        }
    }
}
