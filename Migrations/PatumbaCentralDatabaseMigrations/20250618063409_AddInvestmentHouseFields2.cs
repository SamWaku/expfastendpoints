using Microsoft.EntityFrameworkCore.Metadata;
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
            
            //fixed term deposit table
            migrationBuilder.AddColumn<double>(
                name: "Discount",
                table: "treasury_bills",
                nullable: true
            );

            // migrationBuilder.AddColumn<Enum>(
            //     name: "Status",
            //     table:"fixed_term_deposits",
            //     nullable: true,
            //     defaultValue: ["Approved", "Pending", "Rejected"]
            // );
            
            
            migrationBuilder.CreateTable(
                name: "ContactPerson",
                columns: table => new
                {
                    InvestmentHouseId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Position = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactPerson", x => new { x.InvestmentHouseId, x.Id });
                    table.ForeignKey(
                        name: "FK_ContactPerson_investment_houses_InvestmentHouseId",
                        column: x => x.InvestmentHouseId,
                        principalTable: "investment_houses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
            .Annotation("MySql:CharSet", "utf8mb4");
            
            migrationBuilder.CreateTable(
                name: "Director",
                columns: table => new
                {
                    InvestmentHouseId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Position = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Director", x => new { x.InvestmentHouseId, x.Id });
                    table.ForeignKey(
                        name: "FK_Director_investment_houses_InvestmentHouseId",
                        column: x => x.InvestmentHouseId,
                        principalTable: "investment_houses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
            .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
