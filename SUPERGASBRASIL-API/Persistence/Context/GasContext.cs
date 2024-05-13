using Microsoft.EntityFrameworkCore;
using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Persistence.Context
{
    public class GasContext : DbContext
    {
        public GasContext(DbContextOptions<GasContext> options) : base(options)
        { }

        public DbSet<Admin> Admin { get; set; }
        public DbSet<ClientLegalEntity> ClientLegal { get; set; }
        public DbSet<ClientNaturalPerson> ClientNatural { get; set; }
        public DbSet<GeneralReport> GeneralReport { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Sales> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Admin>(a =>
            {
                a.ToTable("tbl_Admin");
                a.HasKey(e => e.IdAdmin);
                a.Property(e => e.Username)
                  .IsRequired()
                  .HasMaxLength(50);
                a.Property(e => e.Password)
                  .IsRequired()
                  .HasMaxLength(8);
            });

            modelBuilder.Entity<ClientLegalEntity>(c =>
            {
                c.ToTable("tbl_ClientJuridico");
                c.HasKey(e => e.IdClientLegalEntity);
                c.Property(e => e.CompanyName)
                 .IsRequired()
                 .HasMaxLength(100);
                c.Property(e => e.TypeOfCompany)
                 .IsRequired()
                 .HasMaxLength(100);
                c.Property(e => e.BusinessAddress)
                 .IsRequired()
                 .HasMaxLength(100);
                c.Property(e => e.TaxIdentificationNumberCNPJ)
                 .IsRequired()
                 .HasMaxLength(11);
                c.Property(e => e.ContactInformation)
                 .IsRequired()
                 .HasMaxLength(11);
            });

            modelBuilder.Entity<ClientNaturalPerson>(c =>
            {
                c.ToTable("tbl_ClientFisico");
                c.HasKey(e => e.IdClientNaturalPerson);
                c.Property(e => e.Name)
                 .IsRequired()
                 .HasMaxLength(100);
                c.Property(e => e.Age)
                 .IsRequired()
                 .HasMaxLength(100);
                c.Property(e => e.DateOfBirth)
                 .IsRequired();
                c.Property(e => e.CPF)
                 .IsRequired()
                 .HasMaxLength(11);
            });

            modelBuilder.Entity<ClientNaturalPerson>(c =>
            {
                c.ToTable("tbl_ClientFisico");
                c.HasKey(e => e.IdClientNaturalPerson);
                c.Property(e => e.Name)
                 .IsRequired()
                 .HasMaxLength(100);
                c.Property(e => e.Age)
                 .IsRequired()
                 .HasMaxLength(100);
                c.Property(e => e.DateOfBirth)
                 .IsRequired();
                c.Property(e => e.CPF)
                 .IsRequired()
                 .HasMaxLength(11);
            });

            modelBuilder.Entity<Employees>(c =>
            {
                c.ToTable("tbl_Funcionarios");
                c.HasKey(e => e.IdEmployees);
                c.Property(e => e.Name)
                 .IsRequired()
                 .HasMaxLength(100);
                c.Property(e => e.Age)
                 .IsRequired()
                 .HasMaxLength(100);
                c.Property(e => e.DateOfBirth)
                 .IsRequired();
                c.Property(e => e.Salary)
                 .IsRequired()
                 .HasMaxLength(11);
                c.Property(e => e.HireDate)
                 .IsRequired();
            });

            modelBuilder.Entity<GeneralReport>(c =>
            {
                c.ToTable("tbl_Relatorio");
                c.Property(e => e.KitchenGasQuantity)
                 .IsRequired();
                c.Property(e => e.IndustrialGasQuantity)
                 .IsRequired();
                c.Property(e => e.SalesValue)
                 .IsRequired();
                c.Property(e => e.RefillKitchenGas)
                 .IsRequired();
                c.Property(e => e.RefillIndustrialGas)
                 .IsRequired();
            });

            modelBuilder.Entity<Sales>(c =>
            {
                c.ToTable("tbl_Vendas");
                c.Property(e => e.ClientName)
                 .IsRequired();
                c.Property(e => e.Quantity)
                 .IsRequired();
                c.Property(e => e.Type)
                 .IsRequired();
                c.Property(e => e.TimeOfSale)
                 .IsRequired();
            });
        }

    }
}
