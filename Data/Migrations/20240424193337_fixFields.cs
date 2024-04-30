using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class fixFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ProgramEducationalOrganization",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "EducationProgram",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 3,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 4,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 5,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 6,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 7,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 8,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 9,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 10,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 11,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 12,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 13,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 14,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 15,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 16,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 17,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 18,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 19,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 20,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 21,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 22,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 23,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 24,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 25,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 26,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 27,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 28,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 29,
                column: "SpecializationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 30,
                column: "SpecializationId",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ProgramEducationalOrganization");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "EducationProgram");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 3,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 4,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 5,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 6,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 7,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 8,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 9,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 10,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 11,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 12,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 13,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 14,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 15,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 16,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 17,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 18,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 19,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 20,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 21,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 22,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 23,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 24,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 25,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 26,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 27,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 28,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 29,
                column: "SpecializationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 30,
                column: "SpecializationId",
                value: 2);
        }
    }
}
