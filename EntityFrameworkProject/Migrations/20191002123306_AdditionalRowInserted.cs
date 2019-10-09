using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkProject.Migrations
{
    public partial class AdditionalRowInserted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("ac710e1c-e030-4d77-9d41-cefefefee18c"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("c796ea9a-2068-4d18-aea7-9b476cb23a4f"));

            migrationBuilder.DropColumn(
                name: "AnotherPrimaryKey",
                table: "Student");

            migrationBuilder.AlterColumn<bool>(
                name: "IsRegularStudent",
                table: "Student",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool));

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("a6355f6d-ee7b-4dfa-86d4-3c0baf2595d7"), 30, "John Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("c92ebc6d-a04b-4e0f-85f7-5ee622b341d8"), 25, "Jane Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "Name" },
                values: new object[] { new Guid("51cbbad9-e437-4df6-b65d-c6868abca9cd"), 28, "Mike Miles" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("51cbbad9-e437-4df6-b65d-c6868abca9cd"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("a6355f6d-ee7b-4dfa-86d4-3c0baf2595d7"));

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: new Guid("c92ebc6d-a04b-4e0f-85f7-5ee622b341d8"));

            migrationBuilder.AlterColumn<bool>(
                name: "IsRegularStudent",
                table: "Student",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AnotherPrimaryKey",
                table: "Student",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "AnotherPrimaryKey", "IsRegularStudent", "Name" },
                values: new object[] { new Guid("c796ea9a-2068-4d18-aea7-9b476cb23a4f"), 30, new Guid("00000000-0000-0000-0000-000000000000"), false, "John Doe" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "Age", "AnotherPrimaryKey", "IsRegularStudent", "Name" },
                values: new object[] { new Guid("ac710e1c-e030-4d77-9d41-cefefefee18c"), 25, new Guid("00000000-0000-0000-0000-000000000000"), false, "Jane Doe" });
        }
    }
}
