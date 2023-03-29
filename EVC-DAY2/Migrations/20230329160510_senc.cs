using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EVC_DAY2.Migrations
{
    /// <inheritdoc />
    public partial class senc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Courses");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Courses",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
