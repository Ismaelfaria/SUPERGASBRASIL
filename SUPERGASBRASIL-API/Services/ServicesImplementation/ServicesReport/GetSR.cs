using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceReport;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceReport;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesReport
{
    public class GetSR : IGetServR
    {
        private readonly IGetR GetR;
        public GetSR(IGetR getR)
        {
            GetR = getR;
        }
        public IEnumerable<GeneralReport> FindAll()
        {
            var usersDatabase = GetR.FindAll();

            return usersDatabase;
        }

        public GeneralReport FindByDateGenerated(DateTime dataRelatorio)
        {
            var usersDatabase = GetR.FindByDateGenerated(dataRelatorio);

            return usersDatabase;
        }
    }
}
