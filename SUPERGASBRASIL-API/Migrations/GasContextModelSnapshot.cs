﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SUPERGASBRASIL_API.Persistence.Context;

#nullable disable

namespace SUPERGASBRASIL_API.Migrations
{
    [DbContext(typeof(GasContext))]
    partial class GasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SUPERGASBRASIL_API.Entities.Admin", b =>
                {
                    b.Property<Guid>("IdAdmin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)")
                        .HasColumnName("senha");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NomeAdm");

                    b.HasKey("IdAdmin");

                    b.ToTable("tbl_Admin", (string)null);
                });

            modelBuilder.Entity("SUPERGASBRASIL_API.Entities.ClientLegalEntity", b =>
                {
                    b.Property<Guid>("IdClientLegalEntity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BusinessAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("endereço");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nome_Empresa");

                    b.Property<string>("ContactInformation")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("contato");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("TaxIdentificationNumberCNPJ")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("cnpj");

                    b.Property<int>("TypeOfCompany")
                        .HasMaxLength(100)
                        .HasColumnType("int")
                        .HasColumnName("tipo");

                    b.HasKey("IdClientLegalEntity");

                    b.ToTable("tbl_ClientJuridico", (string)null);
                });

            modelBuilder.Entity("SUPERGASBRASIL_API.Entities.ClientNaturalPerson", b =>
                {
                    b.Property<Guid>("IdClientNaturalPerson")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasMaxLength(100)
                        .HasColumnType("int")
                        .HasColumnName("idade");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("cpf");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_nascimento");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nome_client");

                    b.HasKey("IdClientNaturalPerson");

                    b.ToTable("tbl_ClientFisico", (string)null);
                });

            modelBuilder.Entity("SUPERGASBRASIL_API.Entities.Employees", b =>
                {
                    b.Property<Guid>("IdEmployees")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasMaxLength(100)
                        .HasColumnType("int")
                        .HasColumnName("idade");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_nascimento");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_entrada");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nome_funcionario");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasMaxLength(11)
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("salario");

                    b.HasKey("IdEmployees");

                    b.ToTable("tbl_Funcionarios", (string)null);
                });

            modelBuilder.Entity("SUPERGASBRASIL_API.Entities.PIT.Inventory", b =>
                {
                    b.Property<Guid>("IdInventory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_Criação");

                    b.Property<Guid?>("IdProduct")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantidadeEstoque");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_Atualização");

                    b.HasKey("IdInventory");

                    b.HasIndex("IdProduct")
                        .IsUnique()
                        .HasFilter("[IdProduct] IS NOT NULL");

                    b.ToTable("tbl_Inventory", (string)null);
                });

            modelBuilder.Entity("SUPERGASBRASIL_API.Entities.PIT.Product", b =>
                {
                    b.Property<Guid>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_Criação");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("descrição");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nome_Produto");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("valor");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_Atualização");

                    b.HasKey("IdProduct");

                    b.ToTable("tbl_Product", (string)null);
                });

            modelBuilder.Entity("SUPERGASBRASIL_API.Entities.PIT.Transaction", b =>
                {
                    b.Property<Guid>("IdTransaction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("transação");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("data_Transação");

                    b.Property<Guid>("IdInventary")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdProduct")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantidade");

                    b.Property<int>("Type")
                        .HasColumnType("int")
                        .HasColumnName("tipo");

                    b.HasKey("IdTransaction");

                    b.HasIndex("IdInventary");

                    b.ToTable("tbl_Transaction", (string)null);
                });

            modelBuilder.Entity("SUPERGASBRASIL_API.Entities.PIT.Inventory", b =>
                {
                    b.HasOne("SUPERGASBRASIL_API.Entities.PIT.Product", "Product")
                        .WithOne("Inventoryy")
                        .HasForeignKey("SUPERGASBRASIL_API.Entities.PIT.Inventory", "IdProduct");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SUPERGASBRASIL_API.Entities.PIT.Transaction", b =>
                {
                    b.HasOne("SUPERGASBRASIL_API.Entities.PIT.Inventory", "Inventoryy")
                        .WithMany("Transactions")
                        .HasForeignKey("IdInventary")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventoryy");
                });

            modelBuilder.Entity("SUPERGASBRASIL_API.Entities.PIT.Inventory", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("SUPERGASBRASIL_API.Entities.PIT.Product", b =>
                {
                    b.Navigation("Inventoryy")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
