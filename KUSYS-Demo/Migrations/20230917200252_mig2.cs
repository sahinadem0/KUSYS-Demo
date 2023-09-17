using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KUSYS_Demo.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Students",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CourseName",
                table: "Courses",
                newName: "Name");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "StudentCourses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "StudentCourses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { "CSI101", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { "CSI102", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { "MAT101", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "CreatedDate" },
                values: new object[] { "PHY101", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Code", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 5, "FOL181", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foreign Language I" },
                    { 6, "HST181", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atatürk's Principles and History of Revolutions I" },
                    { 7, "PHY183", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "General Physics I" },
                    { 8, "CAL186", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mathematics II" },
                    { 9, "CAL188", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linear Algebra" },
                    { 10, "CME112", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Programming Languages II" },
                    { 11, "CME114", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Probability and Statistics" },
                    { 12, "FOL182", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foreign Language II" },
                    { 13, "HST182", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atatürk's Principles and History of Revolutions II" },
                    { 14, "PHY186", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "General Physics II" },
                    { 15, "TRK182", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turkish Language II" },
                    { 16, "CAL283", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Differantial Equations" },
                    { 17, "CME221", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Logic Circuits" },
                    { 18, "CME223", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Circuit Analysis" },
                    { 19, "CME225", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Object Oriented Programming" },
                    { 20, "CME227", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Data Structures" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "StudentCourses");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StudentCourses");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Students",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Courses",
                newName: "CourseName");

            migrationBuilder.AddColumn<string>(
                name: "CourseId",
                table: "Courses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CourseId",
                value: "CSI101");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CourseId",
                value: "CSI102");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CourseId",
                value: "MAT101");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CourseId",
                value: "PHY101");
        }
    }
}
