using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Services.Interfaces
{
    public interface IReportService
    {
        GeneralReport CreateReport(GeneralReport relatorio);
        IEnumerable<GeneralReport> FindAll();
        GeneralReport FindByDateGenerated(DateTime dataRelatorio);
    }
}
