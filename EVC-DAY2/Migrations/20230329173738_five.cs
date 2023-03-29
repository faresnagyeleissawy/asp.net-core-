using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EVC_DAY2.Migrations
{
    /// <inheritdoc />
    public partial class five : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Trainees_DepartmentId",
                table: "Trainees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_instructors_CourseId",
                table: "instructors",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_instructors_DepartmentId",
                table: "instructors",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_crsResults_CourseId",
                table: "crsResults",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_crsResults_TraineeId",
                table: "crsResults",
                column: "TraineeId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DepartmentId",
                table: "Courses",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_crsResults_Courses_CourseId",
                table: "crsResults",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_crsResults_Trainees_TraineeId",
                table: "crsResults",
                column: "TraineeId",
                principalTable: "Trainees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_instructors_Courses_CourseId",
                table: "instructors",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_instructors_Departments_DepartmentId",
                table: "instructors",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_Departments_DepartmentId",
                table: "Trainees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_crsResults_Courses_CourseId",
                table: "crsResults");

            migrationBuilder.DropForeignKey(
                name: "FK_crsResults_Trainees_TraineeId",
                table: "crsResults");

            migrationBuilder.DropForeignKey(
                name: "FK_instructors_Courses_CourseId",
                table: "instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_instructors_Departments_DepartmentId",
                table: "instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainees_Departments_DepartmentId",
                table: "Trainees");

            migrationBuilder.DropIndex(
                name: "IX_Trainees_DepartmentId",
                table: "Trainees");

            migrationBuilder.DropIndex(
                name: "IX_instructors_CourseId",
                table: "instructors");

            migrationBuilder.DropIndex(
                name: "IX_instructors_DepartmentId",
                table: "instructors");

            migrationBuilder.DropIndex(
                name: "IX_crsResults_CourseId",
                table: "crsResults");

            migrationBuilder.DropIndex(
                name: "IX_crsResults_TraineeId",
                table: "crsResults");

            migrationBuilder.DropIndex(
                name: "IX_Courses_DepartmentId",
                table: "Courses");
        }
    }
}
