using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArlebERP.Company.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeDefaultRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CompanyRole",
                columns: new[] { "Id", "CompanyId", "Name" },
                values: new object[] { 5, null, "Employee" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyRole",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
