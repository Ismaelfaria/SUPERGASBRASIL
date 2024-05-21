using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Repositories.Interfaces;
using SUPERGASBRASIL_API.Services.Interfaces;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation
{
    public class ReportService : IReportService
    {
        private readonly IReportRepository Report;

        public ReportService(IReportRepository report)
        {
            Report = report;
        }

        public GeneralReport CreateReport(GeneralReport relatorio)
        {
            Report.CreateReport(relatorio);

            return relatorio;
        }
        public IEnumerable<GeneralReport> FindAll()
        {
            var usersDatabase = Report.FindAll();

            return usersDatabase;
        }

        public GeneralReport FindByDateGenerated(DateTime dataRelatorio)
        {
            var usersDatabase = Report.FindByDateGenerated(dataRelatorio);

            return usersDatabase;
        }
    }
}
