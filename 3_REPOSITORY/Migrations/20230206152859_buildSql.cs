using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3REPOSITORY.Migrations
{
    /// <inheritdoc />
    public partial class buildSql : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdentityNumber",
                table: "users",
                newName: "PersonalNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonalNumber",
                table: "users",
                newName: "IdentityNumber");
        }
    }
}
