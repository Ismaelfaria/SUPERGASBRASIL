using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Services.Interfaces.InterfaceReport
{
    public interface IGet
    {
        IEnumerable<GeneralReport> FindAll();
        GeneralReport FindByDateGenerated(DateTime dataRelatorio);
    }
}
