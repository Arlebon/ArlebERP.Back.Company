using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArlebERP.Company.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeederDone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CompanyRole",
                columns: new[] { "Id", "CompanyId", "Name" },
                values: new object[,]
                {
                    { 1, null, "Admin" },
                    { 2, null, "Accountable" },
                    { 3, null, "Stock Manager" },
                    { 4, null, "RH Manager" }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 2, "ACC", "Accounting" },
                    { 3, "STK", "Stock" },
                    { 4, "RH", "RH" }
                });

            migrationBuilder.InsertData(
                table: "CompanyRole_Permissions",
                columns: new[] { "CompanyRoleId", "PermissionsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CompanyRole_Permissions",
                keyColumns: new[] { "CompanyRoleId", "PermissionsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CompanyRole_Permissions",
                keyColumns: new[] { "CompanyRoleId", "PermissionsId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CompanyRole_Permissions",
                keyColumns: new[] { "CompanyRoleId", "PermissionsId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "CompanyRole_Permissions",
                keyColumns: new[] { "CompanyRoleId", "PermissionsId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "CompanyRole_Permissions",
                keyColumns: new[] { "CompanyRoleId", "PermissionsId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CompanyRole_Permissions",
                keyColumns: new[] { "CompanyRoleId", "PermissionsId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "CompanyRole_Permissions",
                keyColumns: new[] { "CompanyRoleId", "PermissionsId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "CompanyRole",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CompanyRole",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CompanyRole",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CompanyRole",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
