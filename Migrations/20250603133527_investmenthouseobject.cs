using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ExpFastEnpoints.Migrations
{
    /// <inheritdoc />
    public partial class investmenthouseobject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "certificate_of_incorporation",
                schema: "public",
                table: "investment_house",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "company_name",
                schema: "public",
                table: "investment_house",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "company_registration_number",
                schema: "public",
                table: "investment_house",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "country_of_incorporation",
                schema: "public",
                table: "investment_house",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "date_of_incorporation",
                schema: "public",
                table: "investment_house",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "email_address",
                schema: "public",
                table: "investment_house",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "financials",
                schema: "public",
                table: "investment_house",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "institution_type",
                schema: "public",
                table: "investment_house",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mobile_number",
                schema: "public",
                table: "investment_house",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "physical_address",
                schema: "public",
                table: "investment_house",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "postal_address",
                schema: "public",
                table: "investment_house",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "tax_clearance_certificate",
                schema: "public",
                table: "investment_house",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "telephone_number",
                schema: "public",
                table: "investment_house",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tpin",
                schema: "public",
                table: "investment_house",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "trading_license",
                schema: "public",
                table: "investment_house",
                type: "boolean",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "contact_person",
                schema: "public",
                columns: table => new
                {
                    investment_house_id = table.Column<string>(type: "text", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    phone = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    position = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_contact_person", x => new { x.investment_house_id, x.id });
                    table.ForeignKey(
                        name: "fk_contact_person_investment_house_investment_house_id",
                        column: x => x.investment_house_id,
                        principalSchema: "public",
                        principalTable: "investment_house",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "director",
                schema: "public",
                columns: table => new
                {
                    investment_house_id = table.Column<string>(type: "text", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    phone = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    position = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_director", x => new { x.investment_house_id, x.id });
                    table.ForeignKey(
                        name: "fk_director_investment_house_investment_house_id",
                        column: x => x.investment_house_id,
                        principalSchema: "public",
                        principalTable: "investment_house",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contact_person",
                schema: "public");

            migrationBuilder.DropTable(
                name: "director",
                schema: "public");

            migrationBuilder.DropColumn(
                name: "certificate_of_incorporation",
                schema: "public",
                table: "investment_house");

            migrationBuilder.DropColumn(
                name: "company_name",
                schema: "public",
                table: "investment_house");

            migrationBuilder.DropColumn(
                name: "company_registration_number",
                schema: "public",
                table: "investment_house");

            migrationBuilder.DropColumn(
                name: "country_of_incorporation",
                schema: "public",
                table: "investment_house");

            migrationBuilder.DropColumn(
                name: "date_of_incorporation",
                schema: "public",
                table: "investment_house");

            migrationBuilder.DropColumn(
                name: "email_address",
                schema: "public",
                table: "investment_house");

            migrationBuilder.DropColumn(
                name: "financials",
                schema: "public",
                table: "investment_house");

            migrationBuilder.DropColumn(
                name: "institution_type",
                schema: "public",
                table: "investment_house");

            migrationBuilder.DropColumn(
                name: "mobile_number",
                schema: "public",
                table: "investment_house");

            migrationBuilder.DropColumn(
                name: "physical_address",
                schema: "public",
                table: "investment_house");

            migrationBuilder.DropColumn(
                name: "postal_address",
                schema: "public",
                table: "investment_house");

            migrationBuilder.DropColumn(
                name: "tax_clearance_certificate",
                schema: "public",
                table: "investment_house");

            migrationBuilder.DropColumn(
                name: "telephone_number",
                schema: "public",
                table: "investment_house");

            migrationBuilder.DropColumn(
                name: "tpin",
                schema: "public",
                table: "investment_house");

            migrationBuilder.DropColumn(
                name: "trading_license",
                schema: "public",
                table: "investment_house");
        }
    }
}
