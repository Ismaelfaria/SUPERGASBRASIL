using Microsoft.EntityFrameworkCore;
using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Persistence.Context
{
    public class GasContext : DbContext
    {
        public GasContext(DbContextOptions<GasContext> options) : base(options)
        {}

        public DbSet<Admin> Admin { get; set; }
        public DbSet<ClientLegalEntity> ClientLegal { get; set; }
        public DbSet<ClientNaturalPerson> ClientNatural { get; set; }
        public DbSet<GeneralReport> GeneralReport { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Sales> Sales { get; set; }
    }
}
