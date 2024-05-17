using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceReport
{
    public interface IGetR
    {
        IEnumerable<GeneralReport> FindAll();
        GeneralReport FindByDateGenerated(DateTime dataRelatorio);
    }
}
