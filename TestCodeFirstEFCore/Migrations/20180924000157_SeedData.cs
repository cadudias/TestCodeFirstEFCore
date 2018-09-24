using Microsoft.EntityFrameworkCore.Migrations;

namespace TestCodeFirstEFCore.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Client_ClientId",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Product",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "William" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "ClientId", "Name" },
                values: new object[] { 1, 1, "MackBook pro" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "ClientId", "Name" },
                values: new object[] { 2, 1, "MackBook Air" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "ClientId", "Name" },
                values: new object[] { 3, 1, "PlayStation 100" });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Client_ClientId",
                table: "Product",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Client_ClientId",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Product",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Client_ClientId",
                table: "Product",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
