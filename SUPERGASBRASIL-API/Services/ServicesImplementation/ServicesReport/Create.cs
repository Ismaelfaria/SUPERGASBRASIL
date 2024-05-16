using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceReport;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceReport;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesReport
{
    public class Create : ICreateServ
    {
        private readonly ICreate CreateR;
        public Create(ICreate createR)
        {
            CreateR = createR;
        }
        public void CreateReport(GeneralReport relatorio)
        {
            CreateR.CreateReport(relatorio);
        }
    }
}
