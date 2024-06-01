using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SUPERGASBRASIL_API.Migrations
{
    /// <inheritdoc />
    public partial class Test5Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Inventory_tbl_Product_IdProduct",
                table: "tbl_Inventory");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Inventory_IdProduct",
                table: "tbl_Inventory");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Product_tbl_Inventory_IdProduct",
                table: "tbl_Product",
                column: "IdProduct",
                principalTable: "tbl_Inventory",
                principalColumn: "IdInventory",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Product_tbl_Inventory_IdProduct",
                table: "tbl_Product");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Inventory_IdProduct",
                table: "tbl_Inventory",
                column: "IdProduct",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Inventory_tbl_Product_IdProduct",
                table: "tbl_Inventory",
                column: "IdProduct",
                principalTable: "tbl_Product",
                principalColumn: "IdProduct",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
