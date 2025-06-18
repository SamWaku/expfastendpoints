using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpFastEnpoints.Migrations.PatumbaCentralDatabaseMigrations
{
    /// <inheritdoc />
    public partial class AddInvestmentHouseFields2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyRegistrationNumber",
                table: "investment_houses",
                nullable: true
            );

            migrationBuilder.AddColumn<string>(
                name: "Tpin",
                table: "investment_houses",
                nullable: true
            );

            migrationBuilder.AddColumn<string>(
                name: "CountryOfIncorporation",
                table: "investment_houses",
                nullable: true
            );

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfIncorporation",
                table: "investment_houses",
                nullable: true
            );

            migrationBuilder.AddColumn<string>(
                name: "PostalAddress",
                table: "investment_houses",
                nullable: true
            );

            migrationBuilder.AddColumn<string>(
                name: "TelephoneNumber",
                table: "investment_houses",
                nullable: true
            );

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "investment_houses",
                nullable: true
            );

            migrationBuilder.AddColumn<Boolean>(
                name: "CertificateOfIncorporation",
                table: "investment_houses",
                nullable: true
            );

            migrationBuilder.AddColumn<Boolean>(
                name: "TaxClearanceCertificate",
                table: "investment_houses",
                nullable: true
            );

            migrationBuilder.AddColumn<Boolean>(
                name: "TradingLicense",
                table: "investment_houses",
                nullable: true
            );

            migrationBuilder.AddColumn<Boolean>(
                name: "Financials",
                table: "investment_houses",
                nullable: true
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
