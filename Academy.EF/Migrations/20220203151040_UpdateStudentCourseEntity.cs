using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Academy.EF.Migrations
{
    public partial class UpdateStudentCourseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_StudentCourse_StudentCourseID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentCourse_StudentCourseID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentCourseID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Courses_StudentCourseID",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "StudentCourseID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentCourseID",
                table: "Courses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentCourseID",
                table: "Students",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentCourseID",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentCourseID",
                table: "Students",
                column: "StudentCourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StudentCourseID",
                table: "Courses",
                column: "StudentCourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_StudentCourse_StudentCourseID",
                table: "Courses",
                column: "StudentCourseID",
                principalTable: "StudentCourse",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentCourse_StudentCourseID",
                table: "Students",
                column: "StudentCourseID",
                principalTable: "StudentCourse",
                principalColumn: "ID");
        }
    }
}
