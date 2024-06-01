using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SUPERGASBRASIL_API.Migrations
{
    /// <inheritdoc />
    public partial class TestMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Inventory_tbl_Product_IdProduct",
                table: "tbl_Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Inventory_tbl_Product_productIdProduct",
                table: "tbl_Inventory");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Inventory_productIdProduct",
                table: "tbl_Inventory");

            migrationBuilder.DropColumn(
                name: "productIdProduct",
                table: "tbl_Inventory");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "tbl_Transaction",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Inventory_tbl_Product_IdProduct",
                table: "tbl_Inventory",
                column: "IdProduct",
                principalTable: "tbl_Product",
                principalColumn: "IdProduct");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Inventory_tbl_Product_IdProduct",
                table: "tbl_Inventory");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "tbl_Transaction",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<Guid>(
                name: "productIdProduct",
                table: "tbl_Inventory",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Inventory_productIdProduct",
                table: "tbl_Inventory",
                column: "productIdProduct");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Inventory_tbl_Product_IdProduct",
                table: "tbl_Inventory",
                column: "IdProduct",
                principalTable: "tbl_Product",
                principalColumn: "IdProduct",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Inventory_tbl_Product_productIdProduct",
                table: "tbl_Inventory",
                column: "productIdProduct",
                principalTable: "tbl_Product",
                principalColumn: "IdProduct",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
