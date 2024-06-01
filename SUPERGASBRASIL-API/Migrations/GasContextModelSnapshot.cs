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
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ContactInformation")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("TaxIdentificationNumberCNPJ")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int>("TypeOfCompany")
                        .HasMaxLength(100)
                        .HasColumnType("int");

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
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

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
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasMaxLength(11)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdEmployees");

                    b.ToTable("tbl_Funcionarios", (string)null);
                });

            modelBuilder.Entity("SUPERGASBRASIL_API.Entities.PIT.Inventory", b =>
                {
                    b.Property<Guid>("IdInventory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdProduct")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("IdInventory");

                    b.ToTable("tbl_Inventory", (string)null);
                });

            modelBuilder.Entity("SUPERGASBRASIL_API.Entities.PIT.Product", b =>
                {
                    b.Property<Guid>("IdProduct")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("IdProduct");

                    b.ToTable("tbl_Product", (string)null);
                });

            modelBuilder.Entity("SUPERGASBRASIL_API.Entities.PIT.Transaction", b =>
                {
                    b.Property<Guid>("IdTransaction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdProduct")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("IdTransaction");

                    b.HasIndex("IdProduct");

                    b.ToTable("tbl_Transaction", (string)null);
                });

            modelBuilder.Entity("SUPERGASBRASIL_API.Entities.PIT.Product", b =>
                {
                    b.HasOne("SUPERGASBRASIL_API.Entities.PIT.Inventory", "Inventoryy")
                        .WithOne("Product")
                        .HasForeignKey("SUPERGASBRASIL_API.Entities.PIT.Product", "IdProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventoryy");
                });

            modelBuilder.Entity("SUPERGASBRASIL_API.Entities.PIT.Transaction", b =>
                {
                    b.HasOne("SUPERGASBRASIL_API.Entities.PIT.Product", "Product")
                        .WithMany("Transactions")
                        .HasForeignKey("IdProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SUPERGASBRASIL_API.Entities.PIT.Inventory", b =>
                {
                    b.Navigation("Product")
                        .IsRequired();
                });

            modelBuilder.Entity("SUPERGASBRASIL_API.Entities.PIT.Product", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
