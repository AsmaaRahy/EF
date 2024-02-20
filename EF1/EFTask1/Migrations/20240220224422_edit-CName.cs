using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFTask1.Migrations
{
    /// <inheritdoc />
    public partial class editCName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "NewTask",
                newName: "Deadline");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Deadline",
                table: "NewTask",
                newName: "Date");
        }
    }
}
