using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpFastEnpoints.Migrations
{
    /// <inheritdoc />
    public partial class fixeddepositinvest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_fixed_term_deposit_investment_house_investment_house_id",
                schema: "public",
                table: "fixed_term_deposit");

            migrationBuilder.DropIndex(
                name: "ix_fixed_term_deposit_investment_house_id",
                schema: "public",
                table: "fixed_term_deposit");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "ix_fixed_term_deposit_investment_house_id",
                schema: "public",
                table: "fixed_term_deposit",
                column: "investment_house_id");

            migrationBuilder.AddForeignKey(
                name: "fk_fixed_term_deposit_investment_house_investment_house_id",
                schema: "public",
                table: "fixed_term_deposit",
                column: "investment_house_id",
                principalSchema: "public",
                principalTable: "investment_house",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
