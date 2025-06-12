using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ExpFastEnpoints.Migrations
{
    /// <inheritdoc />
    public partial class user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "commercial_paper",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    company_name = table.Column<string>(type: "text", nullable: false),
                    invested_amount = table.Column<double>(type: "double precision", nullable: false),
                    interest_rate = table.Column<double>(type: "double precision", nullable: false),
                    tenure = table.Column<int>(type: "integer", nullable: false),
                    start_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    maturity_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_commercial_paper", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "equity",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    order_type = table.Column<int>(type: "integer", nullable: false),
                    company = table.Column<string>(type: "text", nullable: true),
                    quantity = table.Column<double>(type: "double precision", nullable: false),
                    share_price = table.Column<double>(type: "double precision", nullable: false),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_equity", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "investment_house",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    company_name = table.Column<string>(type: "text", nullable: true),
                    institution_type = table.Column<string>(type: "text", nullable: true),
                    company_registration_number = table.Column<string>(type: "text", nullable: true),
                    tpin = table.Column<string>(type: "text", nullable: true),
                    country_of_incorporation = table.Column<string>(type: "text", nullable: true),
                    date_of_incorporation = table.Column<DateOnly>(type: "date", nullable: false),
                    physical_address = table.Column<string>(type: "text", nullable: true),
                    postal_address = table.Column<string>(type: "text", nullable: true),
                    telephone_number = table.Column<string>(type: "text", nullable: true),
                    mobile_number = table.Column<string>(type: "text", nullable: true),
                    email_address = table.Column<string>(type: "text", nullable: true),
                    certificate_of_incorporation = table.Column<bool>(type: "boolean", nullable: true),
                    tax_clearance_certificate = table.Column<bool>(type: "boolean", nullable: true),
                    trading_license = table.Column<bool>(type: "boolean", nullable: true),
                    financials = table.Column<bool>(type: "boolean", nullable: true),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_investment_house", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sms_inactivity",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    text = table.Column<string>(type: "text", nullable: true),
                    msisdn = table.Column<string>(type: "text", nullable: true),
                    band = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sms_inactivity", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    date_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "contact_person",
                schema: "public",
                columns: table => new
                {
                    investment_house_id = table.Column<int>(type: "integer", nullable: false),
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
                    investment_house_id = table.Column<int>(type: "integer", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "fixed_term_deposit",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    amount = table.Column<double>(type: "double precision", nullable: false),
                    investment_house_id = table.Column<int>(type: "integer", nullable: false),
                    interest_rate = table.Column<double>(type: "double precision", nullable: false),
                    tenure = table.Column<int>(type: "integer", nullable: false),
                    start_date = table.Column<DateOnly>(type: "date", nullable: false),
                    maturity_date = table.Column<DateOnly>(type: "date", nullable: false),
                    interest_amount = table.Column<double>(type: "double precision", nullable: false),
                    maturity_amount = table.Column<double>(type: "double precision", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
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
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "commercial_paper",
                schema: "public");

            migrationBuilder.DropTable(
                name: "contact_person",
                schema: "public");

            migrationBuilder.DropTable(
                name: "director",
                schema: "public");

            migrationBuilder.DropTable(
                name: "equity",
                schema: "public");

            migrationBuilder.DropTable(
                name: "fixed_term_deposit",
                schema: "public");

            migrationBuilder.DropTable(
                name: "sms_inactivity",
                schema: "public");

            migrationBuilder.DropTable(
                name: "user",
                schema: "public");

            migrationBuilder.DropTable(
                name: "investment_house",
                schema: "public");
        }
    }
}
