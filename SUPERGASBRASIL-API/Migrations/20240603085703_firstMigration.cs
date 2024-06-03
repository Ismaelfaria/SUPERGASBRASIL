using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SUPERGASBRASIL_API.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Admin",
                columns: table => new
                {
                    IdAdmin = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Admin", x => x.IdAdmin);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientFisico",
                columns: table => new
                {
                    IdClientNaturalPerson = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Age = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientFisico", x => x.IdClientNaturalPerson);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ClientJuridico",
                columns: table => new
                {
                    IdClientLegalEntity = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TypeOfCompany = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    BusinessAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TaxIdentificationNumberCNPJ = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    ContactInformation = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ClientJuridico", x => x.IdClientLegalEntity);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Funcionarios",
                columns: table => new
                {
                    IdEmployees = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Age = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", maxLength: 11, nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Funcionarios", x => x.IdEmployees);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Product",
                columns: table => new
                {
                    IdProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Product", x => x.IdProduct);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Inventory",
                columns: table => new
                {
                    IdInventory = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Inventory", x => x.IdInventory);
                    table.ForeignKey(
                        name: "FK_tbl_Inventory_tbl_Product_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "tbl_Product",
                        principalColumn: "IdProduct");
                });

            migrationBuilder.CreateTable(
                name: "tbl_Transaction",
                columns: table => new
                {
                    IdTransaction = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdInventary = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Transaction", x => x.IdTransaction);
                    table.ForeignKey(
                        name: "FK_tbl_Transaction_tbl_Inventory_IdInventary",
                        column: x => x.IdInventary,
                        principalTable: "tbl_Inventory",
                        principalColumn: "IdInventory",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Inventory_IdProduct",
                table: "tbl_Inventory",
                column: "IdProduct",
                unique: true,
                filter: "[IdProduct] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Transaction_IdInventary",
                table: "tbl_Transaction",
                column: "IdInventary");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Admin");

            migrationBuilder.DropTable(
                name: "tbl_ClientFisico");

            migrationBuilder.DropTable(
                name: "tbl_ClientJuridico");

            migrationBuilder.DropTable(
                name: "tbl_Funcionarios");

            migrationBuilder.DropTable(
                name: "tbl_Transaction");

            migrationBuilder.DropTable(
                name: "tbl_Inventory");

            migrationBuilder.DropTable(
                name: "tbl_Product");
        }
    }
}
