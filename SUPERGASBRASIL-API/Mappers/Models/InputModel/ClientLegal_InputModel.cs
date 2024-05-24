using SUPERGASBRASIL_API.Entities.Enum;

namespace SUPERGASBRASIL_API.Mappers.Models.InputModel
{
    public class ClientLegal_InputModel
    {
        public string CompanyName { get; set; }
        public SizeOfCompanies TypeOfCompany { get; set; }
        public string BusinessAddress { get; set; }
        public string TaxIdentificationNumberCNPJ { get; set; }
        public string ContactInformation { get; set; }
    }
}
