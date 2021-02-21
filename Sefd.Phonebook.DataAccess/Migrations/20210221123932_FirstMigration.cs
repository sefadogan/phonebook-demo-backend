using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sefd.Phonebook.DataAccess.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 2, 21, 15, 39, 31, 652, DateTimeKind.Local).AddTicks(2103)),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "char(10)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(320)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(2021, 2, 21, 15, 39, 31, 667, DateTimeKind.Local).AddTicks(3310)),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactInformations_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CompanyName", "FirstName", "IsDeleted", "LastName", "UpdatedDate" },
                values: new object[] { 1, "Itelligence Türkiye", "Sefa", false, "DOĞAN", null });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CompanyName", "FirstName", "IsDeleted", "LastName", "UpdatedDate" },
                values: new object[] { 2, "Yer Altı", "Polat", false, "ALEMDAR", null });

            migrationBuilder.CreateIndex(
                name: "IX_ContactInformations_ContactId",
                table: "ContactInformations",
                column: "ContactId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactInformations");

            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
