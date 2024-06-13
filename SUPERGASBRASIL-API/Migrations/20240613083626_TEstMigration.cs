using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SUPERGASBRASIL_API.Migrations
{
    /// <inheritdoc />
    public partial class TEstMigration : Migration
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

            migrationBuilder.AlterColumn<Guid>(
                name: "IdProduct",
                table: "tbl_Inventory",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameProduct",
                table: "tbl_Inventory",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Inventory_tbl_Product_IdProduct",
                table: "tbl_Inventory");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Inventory_IdProduct",
                table: "tbl_Inventory");

            migrationBuilder.DropColumn(
                name: "NameProduct",
                table: "tbl_Inventory");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdProduct",
                table: "tbl_Inventory",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Inventory_IdProduct",
                table: "tbl_Inventory",
                column: "IdProduct",
                unique: true,
                filter: "[IdProduct] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Inventory_tbl_Product_IdProduct",
                table: "tbl_Inventory",
                column: "IdProduct",
                principalTable: "tbl_Product",
                principalColumn: "IdProduct");
        }
    }
}
