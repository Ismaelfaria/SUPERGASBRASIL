using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SUPERGASBRASIL_API.Migrations
{
    /// <inheritdoc />
    public partial class addMigrationGad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nome_cadastro",
                table: "tbl_ClientJuridico",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tbl_ClientJuridico",
                newName: "nome_cadastro");
        }
    }
}
