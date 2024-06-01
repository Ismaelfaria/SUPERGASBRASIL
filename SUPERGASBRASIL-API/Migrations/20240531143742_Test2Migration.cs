using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SUPERGASBRASIL_API.Migrations
{
    /// <inheritdoc />
    public partial class Test2Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Inventory_tbl_Product_IdProduct",
                table: "tbl_Inventory");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Inventory_tbl_Product_IdProduct",
                table: "tbl_Inventory",
                column: "IdProduct",
                principalTable: "tbl_Product",
                principalColumn: "IdProduct",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Inventory_tbl_Product_IdProduct",
                table: "tbl_Inventory");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Inventory_tbl_Product_IdProduct",
                table: "tbl_Inventory",
                column: "IdProduct",
                principalTable: "tbl_Product",
                principalColumn: "IdProduct");
        }
    }
}
