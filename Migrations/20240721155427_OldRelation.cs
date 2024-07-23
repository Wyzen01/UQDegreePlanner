using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UQDegreePlanner.Migrations
{
    /// <inheritdoc />
    public partial class OldRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DegreeId",
                table: "Degrees");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DegreeId",
                table: "Degrees",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
