using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArlebERP.Company.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeederTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[] { 1, "GLO", "Global Modifidcation" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
