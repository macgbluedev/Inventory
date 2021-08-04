using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "07ce47c9-b904-41ab-8326-98d6da695c35");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "cee05684-17f9-4492-bc18-968bc50bacd6");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAdress", "WarehouseName" },
                values: new object[] { "eb05e5d8-ec1b-49fb-8320-2beec2db4c9c", "Calle 8 con 23, MAD", "Almacén Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAdress", "WarehouseName" },
                values: new object[] { "2ebba171-2462-4627-b4e2-a58463f3be73", "Calle 14, MAD", "Almacén A" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "2ebba171-2462-4627-b4e2-a58463f3be73");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "eb05e5d8-ec1b-49fb-8320-2beec2db4c9c");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAdress", "WarehouseName" },
                values: new object[] { "07ce47c9-b904-41ab-8326-98d6da695c35", "Calle 8 con 23, MAD", "Almacén Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAdress", "WarehouseName" },
                values: new object[] { "cee05684-17f9-4492-bc18-968bc50bacd6", "Calle 14, MAD", "Almacén A" });
        }
    }
}
