using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryReport
{
    public class ReportRepository : IReportRepository
    {
        private readonly GasContext _context;

        public ReportRepository(GasContext context)
        {
            _context = context;
        }

        public GeneralReport CreateReport(GeneralReport relatorio)
        {
            _context.GeneralReport.Add(relatorio);
            _context.SaveChanges();

            return relatorio;
        }
        public IEnumerable<GeneralReport> FindAll()
        {
            var usersDatabase = _context.GeneralReport.ToList();

            return usersDatabase;
        }

        public GeneralReport FindByDateGenerated(DateTime dataRelatorio)
        {
            var userDatabase = _context.GeneralReport.SingleOrDefault(a => a.DateGenerated == dataRelatorio);

            if (userDatabase == null)
            {
                return null;
            }

            return userDatabase;
        }
    }
}
