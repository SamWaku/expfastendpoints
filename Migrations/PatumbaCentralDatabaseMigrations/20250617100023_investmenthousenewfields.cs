using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace ExpFastEnpoints.Migrations.PatumbaCentralDatabaseMigrations
{
    /// <inheritdoc />
    public partial class investmenthousenewfields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "investment_houses",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(type: "longtext", nullable: true),
                    InstitutionType = table.Column<string>(type: "longtext", nullable: true),
                    CompanyRegistrationNumber = table.Column<string>(type: "longtext", nullable: true),
                    Tpin = table.Column<string>(type: "longtext", nullable: true),
                    CountryOfIncorporation = table.Column<string>(type: "longtext", nullable: true),
                    DateOfIncorporation = table.Column<DateOnly>(type: "date", nullable: false),
                    PhysicalAddress = table.Column<string>(type: "longtext", nullable: true),
                    PostalAddress = table.Column<string>(type: "longtext", nullable: true),
                    TelephoneNumber = table.Column<string>(type: "longtext", nullable: true),
                    MobileNumber = table.Column<string>(type: "longtext", nullable: true),
                    EmailAddress = table.Column<string>(type: "longtext", nullable: true),
                    CertificateOfIncorporation = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    TaxClearanceCertificate = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    TradingLicense = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Financials = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_investment_houses", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ContactPerson",
                schema: "public",
                columns: table => new
                {
                    InvestmentHouseId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    Phone = table.Column<string>(type: "longtext", nullable: true),
                    Email = table.Column<string>(type: "longtext", nullable: true),
                    Position = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactPerson", x => new { x.InvestmentHouseId, x.Id });
                    table.ForeignKey(
                        name: "FK_ContactPerson_investment_houses_InvestmentHouseId",
                        column: x => x.InvestmentHouseId,
                        principalSchema: "public",
                        principalTable: "investment_houses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Director",
                schema: "public",
                columns: table => new
                {
                    InvestmentHouseId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    Phone = table.Column<string>(type: "longtext", nullable: true),
                    Email = table.Column<string>(type: "longtext", nullable: true),
                    Position = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Director", x => new { x.InvestmentHouseId, x.Id });
                    table.ForeignKey(
                        name: "FK_Director_investment_houses_InvestmentHouseId",
                        column: x => x.InvestmentHouseId,
                        principalSchema: "public",
                        principalTable: "investment_houses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactPerson",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Director",
                schema: "public");

            migrationBuilder.DropTable(
                name: "investment_houses",
                schema: "public");
        }
    }
}
