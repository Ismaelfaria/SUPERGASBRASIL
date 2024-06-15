using SUPERGASBRASIL_API.Entities.Enum;

namespace SUPERGASBRASIL_API.Mappers.Models.InputModel
{
    public class ClientLegal_InputModel
    {
        public string Name { get; set; }
        public string TaxIdentificationNumberCNPJ { get; set; }
        public int ContactInformation { get; set; }
    }
}
