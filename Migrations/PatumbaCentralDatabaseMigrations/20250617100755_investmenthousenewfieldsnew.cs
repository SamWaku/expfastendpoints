using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace ExpFastEnpoints.Migrations.PatumbaCentralDatabaseMigrations
{
    /// <inheritdoc />
    public partial class investmenthousenewfieldsnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                schema: "public",
                table: "investment_houses");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                schema: "public",
                table: "investment_houses");

            migrationBuilder.DropColumn(
                name: "PhysicalAddress",
                schema: "public",
                table: "investment_houses");

            migrationBuilder.AlterColumn<string>(
                name: "Tpin",
                schema: "public",
                table: "investment_houses",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TelephoneNumber",
                schema: "public",
                table: "investment_houses",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddress",
                schema: "public",
                table: "investment_houses",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InstitutionType",
                schema: "public",
                table: "investment_houses",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                schema: "public",
                table: "investment_houses",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CountryOfIncorporation",
                schema: "public",
                table: "investment_houses",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyRegistrationNumber",
                schema: "public",
                table: "investment_houses",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                schema: "public",
                table: "investment_houses",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "ContactNumber",
                schema: "public",
                table: "investment_houses",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "public",
                table: "investment_houses",
                type: "longtext",
                nullable: false);

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                schema: "public",
                table: "Director",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                schema: "public",
                table: "Director",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "public",
                table: "Director",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "public",
                table: "Director",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                schema: "public",
                table: "ContactPerson",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                schema: "public",
                table: "ContactPerson",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "public",
                table: "ContactPerson",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "public",
                table: "ContactPerson",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "fixed_term_deposits",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<double>(type: "double", nullable: false),
                    InvestmentHouseId = table.Column<int>(type: "int", nullable: false),
                    InterestRate = table.Column<double>(type: "double", nullable: false),
                    Tenure = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    MaturityDate = table.Column<DateOnly>(type: "date", nullable: false),
                    InterestAmount = table.Column<double>(type: "double", nullable: false),
                    MaturityAmount = table.Column<double>(type: "double", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fixed_term_deposits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_fixed_term_deposits_investment_houses_InvestmentHouseId",
                        column: x => x.InvestmentHouseId,
                        principalSchema: "public",
                        principalTable: "investment_houses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_fixed_term_deposits_InvestmentHouseId",
                schema: "public",
                table: "fixed_term_deposits",
                column: "InvestmentHouseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fixed_term_deposits",
                schema: "public");

            migrationBuilder.DropColumn(
                name: "Address",
                schema: "public",
                table: "investment_houses");

            migrationBuilder.DropColumn(
                name: "ContactNumber",
                schema: "public",
                table: "investment_houses");

            migrationBuilder.DropColumn(
                name: "Name",
                schema: "public",
                table: "investment_houses");

            migrationBuilder.AlterColumn<string>(
                name: "Tpin",
                schema: "public",
                table: "investment_houses",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "TelephoneNumber",
                schema: "public",
                table: "investment_houses",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddress",
                schema: "public",
                table: "investment_houses",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "InstitutionType",
                schema: "public",
                table: "investment_houses",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                schema: "public",
                table: "investment_houses",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "CountryOfIncorporation",
                schema: "public",
                table: "investment_houses",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyRegistrationNumber",
                schema: "public",
                table: "investment_houses",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                schema: "public",
                table: "investment_houses",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                schema: "public",
                table: "investment_houses",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhysicalAddress",
                schema: "public",
                table: "investment_houses",
                type: "longtext",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                schema: "public",
                table: "Director",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                schema: "public",
                table: "Director",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "public",
                table: "Director",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "public",
                table: "Director",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                schema: "public",
                table: "ContactPerson",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                schema: "public",
                table: "ContactPerson",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "public",
                table: "ContactPerson",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "public",
                table: "ContactPerson",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext");
        }
    }
}
