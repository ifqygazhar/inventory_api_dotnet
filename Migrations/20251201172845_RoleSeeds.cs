using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inventory_dotnet.Migrations
{
    /// <inheritdoc />
    public partial class RoleSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "IsActive", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c42718e-6701-4127-b457-3e5831730043", "0c42718e-6701-4127-b457-3e5831730043", "View reports only", true, "Auditor", "AUDITOR" },
                    { "1262f022-7744-48f8-b851-177935c13f99", "1262f022-7744-48f8-b851-177935c13f99", "Manage vendors and PO", true, "Purchasing", "PURCHASING" },
                    { "8af10569-b718-4ac4-9b51-cf862f90260d", "8af10569-b718-4ac4-9b51-cf862f90260d", "Input inbound and outbound items", true, "WarehouseStaff", "WAREHOUSESTAFF" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "bd2bcf0c-20db-474f-8407-5a6b159518bb", "Manage stock and approvals", true, "WarehouseManager", "WAREHOUSEMANAGER" },
                    { "c7b013f0-5201-4317-abd8-c211f91b7330", "c7b013f0-5201-4317-abd8-c211f91b7330", "Full access to all features", true, "SuperAdmin", "SUPERADMIN" },
                    { "f5a54388-1c4b-4f51-877f-178556606f23", "f5a54388-1c4b-4f51-877f-178556606f23", "View stock availability", true, "Sales", "SALES" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0c42718e-6701-4127-b457-3e5831730043");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1262f022-7744-48f8-b851-177935c13f99");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8af10569-b718-4ac4-9b51-cf862f90260d");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f5a54388-1c4b-4f51-877f-178556606f23");
        }
    }
}
