using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3REPOSITORY.Migrations
{
    /// <inheritdoc />
    public partial class buildDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FamilyId",
                table: "users",
                newName: "FamilyCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FamilyCode",
                table: "users",
                newName: "FamilyId");
        }
    }
}
