using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UQDegreePlanner.Migrations
{
    /// <inheritdoc />
    public partial class NewForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DegreeId",
                table: "Degrees",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DegreeId",
                table: "Degrees");
        }
    }
}
