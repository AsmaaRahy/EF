using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFTask1.Migrations
{
    /// <inheritdoc />
    public partial class editname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskEntities",
                table: "TaskEntities");

            migrationBuilder.RenameTable(
                name: "TaskEntities",
                newName: "NewTask");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewTask",
                table: "NewTask",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NewTask",
                table: "NewTask");

            migrationBuilder.RenameTable(
                name: "NewTask",
                newName: "TaskEntities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskEntities",
                table: "TaskEntities",
                column: "Id");
        }
    }
}
