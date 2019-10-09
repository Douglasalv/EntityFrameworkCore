using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkProject.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "AnotherPrimaryKey", "IsRegularStudent", "Name" },
                values: new object[] { new Guid("c796ea9a-2068-4d18-aea7-9b476cb23a4f"), 30, new Guid("00000000-0000-0000-0000-000000000000"), false, "John Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "AnotherPrimaryKey", "IsRegularStudent", "Name" },
                values: new object[] { new Guid("ac710e1c-e030-4d77-9d41-cefefefee18c"), 25, new Guid("00000000-0000-0000-0000-000000000000"), false, "Jane Doe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("ac710e1c-e030-4d77-9d41-cefefefee18c"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("c796ea9a-2068-4d18-aea7-9b476cb23a4f"));
        }
    }
}
