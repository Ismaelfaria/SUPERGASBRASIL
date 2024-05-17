using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceReport;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryReport
{
    public class CreateR : ICreateR
    {
        private readonly GasContext _context;
        public CreateR(GasContext context)
        {
            _context = context;
        }
        public void CreateReport(GeneralReport relatorio)
        {
            _context.GeneralReport.Add(relatorio);
            _context.SaveChanges();
        }
    }
}
