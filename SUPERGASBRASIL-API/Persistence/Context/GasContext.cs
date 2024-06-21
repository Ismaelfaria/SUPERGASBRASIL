using Microsoft.EntityFrameworkCore;
using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Entities.PIT;
using SUPERGASBRASIL_API.Rest.DTO;
using SUPERGASBRASIL_API.Rest.Model;

namespace SUPERGASBRASIL_API.Persistence.Context
{
    public class GasContext : DbContext
    {
        public GasContext(DbContextOptions<GasContext> options) : base(options)
        { }

        public DbSet<Admin> Admin { get; set; }
        public DbSet<User> User { get; set; }
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
                .HasColumnName("NomeAdm")
                  .IsRequired()
                  .HasMaxLength(50);
                a.Property(e => e.Password)
                .HasColumnName("senha")
                  .IsRequired()
                  .HasMaxLength(8);
            });

            modelBuilder.Entity<ClientLegalEntity>(c =>
            {
                c.ToTable("tbl_ClientJuridico");
                c.HasKey(e => e.IdClientLegalEntity);
                c.Property(e => e.Name)
                .HasColumnName("nome_Empresa")
                 .IsRequired()
                 .HasMaxLength(100);
                c.Property(e => e.TaxIdentificationNumberCNPJ)
                .HasColumnName("cnpj")
                 .IsRequired()
                 .HasMaxLength(11);
                c.Property(e => e.ContactInformation)
                .HasColumnName("contato")
                 .IsRequired()
                 .HasMaxLength(11);
            });

            modelBuilder.Entity<ClientNaturalPerson>(c =>
            {
                c.ToTable("tbl_ClientFisico");
                c.HasKey(e => e.IdClientNaturalPerson);
                c.Property(e => e.Name)
                .HasColumnName("nome_client")
                 .IsRequired()
                 .HasMaxLength(100);
                c.Property(e => e.Age)
                .HasColumnName("idade")
                 .IsRequired()
                 .HasMaxLength(100);
                c.Property(e => e.DateOfBirth)
                .HasColumnName("data_nascimento")
                 .IsRequired();
                c.Property(e => e.CPF)
                .HasColumnName("cpf")
                 .IsRequired()
                 .HasMaxLength(11);
            });

            modelBuilder.Entity<Employees>(c =>
            {
                c.ToTable("tbl_Funcionarios");
                c.HasKey(e => e.IdEmployees);
                c.Property(e => e.Name)
                .HasColumnName("nome_funcionario")
                 .IsRequired()
                 .HasMaxLength(100);
                c.Property(e => e.Age)
                .HasColumnName("idade")
                 .IsRequired()
                 .HasMaxLength(100);
                c.Property(e => e.DateOfBirth)
                .HasColumnName("data_nascimento")
                 .IsRequired();
                c.Property(e => e.Salary)
                .HasColumnName("salario")
                 .IsRequired();
                c.Property(e => e.Positions)
                .HasColumnName("cargo")
                 .IsRequired();
                c.Property(e => e.HireDate)
                .HasColumnName("data_entrada")
                 .IsRequired();
            });

            modelBuilder.Entity<Product>(p =>
            {
                p.ToTable("tbl_Product");
                p.HasKey(e => e.IdProduct);
                p.Property(e => e.Name)
                .HasColumnName("nome_Produto")
                    .IsRequired()
                    .HasMaxLength(100);
                p.Property(e => e.Description)
                .HasColumnName("descrição")
                    .HasMaxLength(500);
                p.Property(e => e.Price)
                .HasColumnName("valor")
                    .IsRequired()
                    .HasColumnType("decimal(18,2)");
                p.Property(e => e.CreatedAt)
                .HasColumnName("data_Criação");
                p.Property(e => e.UpdatedAt)
                .HasColumnName("data_Atualização");
                p.HasOne(a => a.Inventoryy)
                .WithOne(b => b.Product)
                .HasForeignKey<Inventory>(b => b.IdProduct);
            });

            modelBuilder.Entity<Inventory>(i =>
            {
                i.ToTable("tbl_Inventory");
                i.HasKey(e => e.IdInventory);
                i.Property(e => e.Quantity)
                .HasColumnName("quantidadeEstoque")
                    .IsRequired();
                i.Property(e => e.CreatedAt)
                .HasColumnName("data_Criação");
                i.Property(e => e.UpdatedAt)
                .HasColumnName("data_Atualização");
                i.HasMany(b => b.Transactions)
                .WithOne(c => c.Inventoryy)
                .HasForeignKey(c => c.IdInventary);
            });

            modelBuilder.Entity<Transaction>(t =>
            {
                t.ToTable("tbl_Transaction");
                t.HasKey(e => e.IdTransaction);
                t.Property(e => e.IdTransaction)
                .HasColumnName("transação")
                    .IsRequired();
                t.Property(e => e.Type)
                .HasColumnName("tipo")
                    .IsRequired();
                t.Property(e => e.Quantity)
                .HasColumnName("quantidade")
                    .IsRequired();
                t.Property(e => e.CreatedAt)
                .HasColumnName("data_Criação")
                    .IsRequired();
                t.Property(e => e.CreatedAt)
                .HasColumnName("data_Transação");
                
            });
            modelBuilder.Entity<User>(t =>
            {
                t.ToTable("tbl_Users");
                t.HasKey(e => e.Id);
                t.Property(e => e.Username)
                .HasColumnName("Usuario")
                    .IsRequired();
                t.Property(e => e.Password)
                .HasColumnName("Senhas")
                    .IsRequired();
                t.Property(e => e.Roles)
                .HasColumnName("Cargo")
                    .IsRequired();
            });
        }
    }
}
