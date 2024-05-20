using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceReport;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceReport;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesReport
{
    public class CreateSR : ICreateServR
    {
        private readonly ICreateR CreateR;
        public CreateSR(ICreateR createR)
        {
            CreateR = createR;
        }
        public GeneralReport CreateReport(GeneralReport relatorio)
        {
            CreateR.CreateReport(relatorio);

            return relatorio;
        }
    }
}
