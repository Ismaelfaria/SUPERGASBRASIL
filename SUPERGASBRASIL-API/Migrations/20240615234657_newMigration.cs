using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SUPERGASBRASIL_API.Migrations
{
    /// <inheritdoc />
    public partial class newMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypeCompany",
                table: "tbl_ClientJuridico");

            migrationBuilder.DropColumn(
                name: "endereço",
                table: "tbl_ClientJuridico");

            migrationBuilder.DropColumn(
                name: "tipo",
                table: "tbl_ClientJuridico");

            migrationBuilder.RenameColumn(
                name: "nome_Empresa",
                table: "tbl_ClientJuridico",
                newName: "nome_cadastro");

            migrationBuilder.CreateTable(
                name: "Task<ResponseGenerico<CnpjModel>>",
                columns: table => new
                {
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Task<ResponseGenerico<CnpjModel>>");

            migrationBuilder.RenameColumn(
                name: "nome_cadastro",
                table: "tbl_ClientJuridico",
                newName: "nome_Empresa");

            migrationBuilder.AddColumn<string>(
                name: "TypeCompany",
                table: "tbl_ClientJuridico",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "endereço",
                table: "tbl_ClientJuridico",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "tipo",
                table: "tbl_ClientJuridico",
                type: "int",
                maxLength: 100,
                nullable: false,
                defaultValue: 0);
        }
    }
}
