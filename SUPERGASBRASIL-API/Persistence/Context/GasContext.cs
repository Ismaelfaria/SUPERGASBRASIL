using Microsoft.EntityFrameworkCore;
using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Entities.PIT;

namespace SUPERGASBRASIL_API.Persistence.Context
{
    public class GasContext : DbContext
    {
        public GasContext(DbContextOptions<GasContext> options) : base(options)
        { }

        public DbSet<Admin> Admin { get; set; }
        public DbSet<ClientLegalEntity> ClientLegal { get; set; }
        public DbSet<ClientNaturalPerson> ClientNatural { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Employees> Employees { get; set; }

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

            modelBuilder.Entity<Product>(p =>
            {
                p.ToTable("tbl_Product");
                p.HasKey(e => e.IdProduct);
                p.Property(e => e.Name)
                 .IsRequired()
                 .HasMaxLength(100);
                p.Property(e => e.Description)
                 .HasMaxLength(500);
                p.Property(e => e.Price)
                 .IsRequired()
                 .HasColumnType("decimal(18,2)");

                p.HasMany(e => e.Transactions)
                 .WithOne(e => e.Product)
                 .HasForeignKey(e => e.IdProduct);

                p.HasOne(e => e.Inventory)
                 .WithOne(e => e.Product)
                 .HasForeignKey<Inventory>(e => e.IdProduct);
            });

            modelBuilder.Entity<Inventory>(i =>
            {
                i.ToTable("tbl_Inventory");
                i.HasKey(e => e.IdInventory);
                i.Property(e => e.IdProduct)
                 .IsRequired();
                i.Property(e => e.Quantity)
                 .IsRequired();

                i.HasOne(e => e.Product)
                 .WithOne(e => e.Inventory)
                 .HasForeignKey<Inventory>(e => e.IdProduct);
            });

            modelBuilder.Entity<Transaction>(t =>
            {
                t.ToTable("tbl_Transaction");
                t.HasKey(e => e.IdTransaction);
                t.Property(e => e.IdProduct)
                 .IsRequired();
                t.Property(e => e.Type)
                 .IsRequired();
                t.Property(e => e.Quantity)
                 .IsRequired();
                t.Property(e => e.CreatedAt)
                 .IsRequired()
                 .HasColumnType("datetime");

                t.HasOne(e => e.Product)
                 .WithMany(e => e.Transactions)
                 .HasForeignKey(e => e.IdProduct);
            });
        }

    }
}
