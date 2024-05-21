using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Repositories.Interfaces
{
    public interface IReportRepository
    {
        GeneralReport CreateReport(GeneralReport relatorio);
        IEnumerable<GeneralReport> FindAll();
        GeneralReport FindByDateGenerated(DateTime dataRelatorio);

    }
}
