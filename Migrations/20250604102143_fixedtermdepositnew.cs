using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpFastEnpoints.Migrations
{
    /// <inheritdoc />
    public partial class fixedtermdepositnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "fixed_term_deposit",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    amount = table.Column<double>(type: "double precision", nullable: false),
                    interest_rate = table.Column<double>(type: "double precision", nullable: false),
                    tenure = table.Column<int>(type: "integer", nullable: false),
                    start_date = table.Column<DateOnly>(type: "date", nullable: false),
                    maturity_date = table.Column<DateOnly>(type: "date", nullable: false),
                    interest_amount = table.Column<double>(type: "double precision", nullable: false),
                    maturity_amount = table.Column<double>(type: "double precision", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    investment_house_id = table.Column<string>(type: "text", nullable: true),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_fixed_term_deposit", x => x.id);
                    table.ForeignKey(
                        name: "fk_fixed_term_deposit_investment_house_investment_house_id",
                        column: x => x.investment_house_id,
                        principalSchema: "public",
                        principalTable: "investment_house",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "ix_fixed_term_deposit_investment_house_id",
                schema: "public",
                table: "fixed_term_deposit",
                column: "investment_house_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fixed_term_deposit",
                schema: "public");
        }
    }
}
