using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpFastEnpoints.Migrations.PatumbaCentralDatabaseMigrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");
            
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

        // migrationBuilder.AddColumn<string>(
            //     name: "InstitutionType",
            //     table: "investment_houses",
            //     nullable:true
            // );
            
            // migrationBuilder.CreateTable(
            //     name: "investment_houses",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         Name = table.Column<string>(type: "longtext", nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         InstitutionType = table.Column<string>(type: "longtext", nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         CompanyRegistrationNumber = table.Column<string>(type: "longtext", nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         Tpin = table.Column<string>(type: "longtext", nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         CountryOfIncorporation = table.Column<string>(type: "longtext", nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         DateOfIncorporation = table.Column<DateOnly>(type: "date", nullable: true),
            //         Address = table.Column<string>(type: "longtext", nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         PostalAddress = table.Column<string>(type: "longtext", nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         TelephoneNumber = table.Column<string>(type: "longtext", nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         ContactNumber = table.Column<string>(type: "longtext", nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         EmailAddress = table.Column<string>(type: "longtext", nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         CertificateOfIncorporation = table.Column<bool>(type: "tinyint(1)", nullable: true),
            //         TaxClearanceCertificate = table.Column<bool>(type: "tinyint(1)", nullable: true),
            //         TradingLicense = table.Column<bool>(type: "tinyint(1)", nullable: true),
            //         Financials = table.Column<bool>(type: "tinyint(1)", nullable: true),
            //         DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: true),
            //         UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_investment_houses", x => x.Id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "ContactPerson",
            //     columns: table => new
            //     {
            //         InvestmentHouseId = table.Column<int>(type: "int", nullable: false),
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         Name = table.Column<string>(type: "longtext", nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         Phone = table.Column<string>(type: "longtext", nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         Email = table.Column<string>(type: "longtext", nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         Position = table.Column<string>(type: "longtext", nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_ContactPerson", x => new { x.InvestmentHouseId, x.Id });
            //         table.ForeignKey(
            //             name: "FK_ContactPerson_investment_houses_InvestmentHouseId",
            //             column: x => x.InvestmentHouseId,
            //             principalTable: "investment_houses",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "Director",
            //     columns: table => new
            //     {
            //         InvestmentHouseId = table.Column<int>(type: "int", nullable: false),
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         Name = table.Column<string>(type: "longtext", nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         Phone = table.Column<string>(type: "longtext", nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         Email = table.Column<string>(type: "longtext", nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         Position = table.Column<string>(type: "longtext", nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Director", x => new { x.InvestmentHouseId, x.Id });
            //         table.ForeignKey(
            //             name: "FK_Director_investment_houses_InvestmentHouseId",
            //             column: x => x.InvestmentHouseId,
            //             principalTable: "investment_houses",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

        //     migrationBuilder.CreateTable(
        //         name: "FixedTermDeposit",
        //         columns: table => new
        //         {
        //             Id = table.Column<int>(type: "int", nullable: false)
        //                 .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
        //             InvestmentHouseId = table.Column<int>(type: "int", nullable: false),
        //             Amount = table.Column<double>(type: "double", nullable: false),
        //             InterestRate = table.Column<double>(type: "double", nullable: false),
        //             Tenure = table.Column<int>(type: "int", nullable: false),
        //             StartDate = table.Column<DateOnly>(type: "date", nullable: false),
        //             MaturityDate = table.Column<DateOnly>(type: "date", nullable: false),
        //             InterestAmount = table.Column<double>(type: "double", nullable: false),
        //             MaturityAmount = table.Column<double>(type: "double", nullable: false),
        //             DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: true),
        //             UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
        //         },
        //         constraints: table =>
        //         {
        //             table.PrimaryKey("PK_FixedTermDeposit", x => x.Id);
        //             table.ForeignKey(
        //                 name: "FK_FixedTermDeposit_investment_houses_InvestmentHouseId",
        //                 column: x => x.InvestmentHouseId,
        //                 principalTable: "investment_houses",
        //                 principalColumn: "Id",
        //                 onDelete: ReferentialAction.Cascade);
        //         })
        //         .Annotation("MySql:CharSet", "utf8mb4");
        //
        //     migrationBuilder.CreateIndex(
        //         name: "IX_FixedTermDeposit_InvestmentHouseId",
        //         table: "FixedTermDeposit",
        //         column: "InvestmentHouseId");
        // }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropTable(
            //     name: "ContactPerson");
            //
            // migrationBuilder.DropTable(
            //     name: "Director");

            // migrationBuilder.DropTable(
            //     name: "FixedTermDeposit");

            // migrationBuilder.DropTable(
            //     name: "investment_houses");
        }
    }
}
