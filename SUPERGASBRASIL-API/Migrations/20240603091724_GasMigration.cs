using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SUPERGASBRASIL_API.Migrations
{
    /// <inheritdoc />
    public partial class GasMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "tbl_Transaction",
                newName: "tipo");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "tbl_Transaction",
                newName: "quantidade");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "tbl_Transaction",
                newName: "data_Transação");

            migrationBuilder.RenameColumn(
                name: "IdTransaction",
                table: "tbl_Transaction",
                newName: "transação");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "tbl_Product",
                newName: "data_Atualização");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "tbl_Product",
                newName: "valor");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tbl_Product",
                newName: "nome_Produto");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "tbl_Product",
                newName: "descrição");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "tbl_Product",
                newName: "data_Criação");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "tbl_Inventory",
                newName: "data_Atualização");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "tbl_Inventory",
                newName: "quantidadeEstoque");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "tbl_Inventory",
                newName: "data_Criação");

            migrationBuilder.RenameColumn(
                name: "Salary",
                table: "tbl_Funcionarios",
                newName: "salario");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tbl_Funcionarios",
                newName: "nome_funcionario");

            migrationBuilder.RenameColumn(
                name: "HireDate",
                table: "tbl_Funcionarios",
                newName: "data_entrada");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "tbl_Funcionarios",
                newName: "data_nascimento");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "tbl_Funcionarios",
                newName: "idade");

            migrationBuilder.RenameColumn(
                name: "TypeOfCompany",
                table: "tbl_ClientJuridico",
                newName: "tipo");

            migrationBuilder.RenameColumn(
                name: "TaxIdentificationNumberCNPJ",
                table: "tbl_ClientJuridico",
                newName: "cnpj");

            migrationBuilder.RenameColumn(
                name: "ContactInformation",
                table: "tbl_ClientJuridico",
                newName: "contato");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "tbl_ClientJuridico",
                newName: "nome_Empresa");

            migrationBuilder.RenameColumn(
                name: "BusinessAddress",
                table: "tbl_ClientJuridico",
                newName: "endereço");

            migrationBuilder.RenameColumn(
                name: "CPF",
                table: "tbl_ClientFisico",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tbl_ClientFisico",
                newName: "nome_client");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "tbl_ClientFisico",
                newName: "data_nascimento");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "tbl_ClientFisico",
                newName: "idade");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "tbl_Admin",
                newName: "NomeAdm");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "tbl_Admin",
                newName: "senha");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tipo",
                table: "tbl_Transaction",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "tbl_Transaction",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "data_Transação",
                table: "tbl_Transaction",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "transação",
                table: "tbl_Transaction",
                newName: "IdTransaction");

            migrationBuilder.RenameColumn(
                name: "valor",
                table: "tbl_Product",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "nome_Produto",
                table: "tbl_Product",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "descrição",
                table: "tbl_Product",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "data_Criação",
                table: "tbl_Product",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "data_Atualização",
                table: "tbl_Product",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "quantidadeEstoque",
                table: "tbl_Inventory",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "data_Criação",
                table: "tbl_Inventory",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "data_Atualização",
                table: "tbl_Inventory",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "salario",
                table: "tbl_Funcionarios",
                newName: "Salary");

            migrationBuilder.RenameColumn(
                name: "nome_funcionario",
                table: "tbl_Funcionarios",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "idade",
                table: "tbl_Funcionarios",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "data_nascimento",
                table: "tbl_Funcionarios",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "data_entrada",
                table: "tbl_Funcionarios",
                newName: "HireDate");

            migrationBuilder.RenameColumn(
                name: "tipo",
                table: "tbl_ClientJuridico",
                newName: "TypeOfCompany");

            migrationBuilder.RenameColumn(
                name: "nome_Empresa",
                table: "tbl_ClientJuridico",
                newName: "CompanyName");

            migrationBuilder.RenameColumn(
                name: "endereço",
                table: "tbl_ClientJuridico",
                newName: "BusinessAddress");

            migrationBuilder.RenameColumn(
                name: "contato",
                table: "tbl_ClientJuridico",
                newName: "ContactInformation");

            migrationBuilder.RenameColumn(
                name: "cnpj",
                table: "tbl_ClientJuridico",
                newName: "TaxIdentificationNumberCNPJ");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "tbl_ClientFisico",
                newName: "CPF");

            migrationBuilder.RenameColumn(
                name: "nome_client",
                table: "tbl_ClientFisico",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "idade",
                table: "tbl_ClientFisico",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "data_nascimento",
                table: "tbl_ClientFisico",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "senha",
                table: "tbl_Admin",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "NomeAdm",
                table: "tbl_Admin",
                newName: "Username");
        }
    }
}
