using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Services.Interfaces.InterfaceReport
{
    public interface IGetServR
    {
        IEnumerable<GeneralReport> FindAll();
        GeneralReport FindByDateGenerated(DateTime dataRelatorio);
    }
}
