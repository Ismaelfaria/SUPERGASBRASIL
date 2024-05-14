using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Repositories.Interfaces
{
    public interface IGeneralReportRepository
    {
        void Create(GeneralReport relatorio);
        void Delete(Guid id);
        IEnumerable<GeneralReport> FindAll();
        GeneralReport FindByDateGenerated(DateTime dataRelatorio);
        void Update(Guid id, GeneralReport relatorio);
    }
}
