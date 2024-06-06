using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SUPERGASBRASIL_API.Migrations
{
    /// <inheritdoc />
    public partial class MigrationGas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "tbl_Users");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "tbl_Users",
                newName: "Usuario");

            migrationBuilder.RenameColumn(
                name: "Roles",
                table: "tbl_Users",
                newName: "Cargo");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "tbl_Users",
                newName: "Senhas");

            migrationBuilder.AlterColumn<long>(
                name: "cnpj",
                table: "tbl_ClientJuridico",
                type: "bigint",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Users",
                table: "tbl_Users",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Users",
                table: "tbl_Users");

            migrationBuilder.RenameTable(
                name: "tbl_Users",
                newName: "User");

            migrationBuilder.RenameColumn(
                name: "Usuario",
                table: "User",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "Senhas",
                table: "User",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Cargo",
                table: "User",
                newName: "Roles");

            migrationBuilder.AlterColumn<string>(
                name: "cnpj",
                table: "tbl_ClientJuridico",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 11);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");
        }
    }
}
