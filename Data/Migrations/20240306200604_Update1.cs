using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "EducationProgram",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "EducationalOrganization",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "mahmat.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "prinfo.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "it.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "ite.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "iteng.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "itec.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "it2.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "it3.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "it4.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "it5.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 11,
                column: "Image",
                value: "it6.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 12,
                column: "Image",
                value: "it7.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 13,
                column: "Image",
                value: "it8.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 14,
                column: "Image",
                value: "it9.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 15,
                column: "Image",
                value: "it11.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 16,
                column: "Image",
                value: "it12.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 17,
                column: "Image",
                value: "it13.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 18,
                column: "Image",
                value: "it14.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 19,
                column: "Image",
                value: "it15.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 20,
                column: "Image",
                value: "it16.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 21,
                column: "Image",
                value: "it17.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 22,
                column: "Image",
                value: "it18.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 23,
                column: "Image",
                value: "it19.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 24,
                column: "Image",
                value: "it20.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 25,
                column: "Image",
                value: "it21.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 26,
                column: "Image",
                value: "it22.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 27,
                column: "Image",
                value: "it23.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 28,
                column: "Image",
                value: "it24.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 29,
                column: "Image",
                value: "it25.png");

            migrationBuilder.UpdateData(
                table: "EducationProgram",
                keyColumn: "Id",
                keyValue: 30,
                column: "Image",
                value: "it10.png");

            migrationBuilder.UpdateData(
                table: "EducationalOrganization",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "msu.jpg");

            migrationBuilder.UpdateData(
                table: "EducationalOrganization",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "mfti.jpg");

            migrationBuilder.UpdateData(
                table: "EducationalOrganization",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "mifi.jpg");

            migrationBuilder.UpdateData(
                table: "EducationalOrganization",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "bauman.jpg");

            migrationBuilder.UpdateData(
                table: "EducationalOrganization",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "prez.jpg");

            migrationBuilder.UpdateData(
                table: "EducationalOrganization",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "kst.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "EducationProgram");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "EducationalOrganization");
        }
    }
}
