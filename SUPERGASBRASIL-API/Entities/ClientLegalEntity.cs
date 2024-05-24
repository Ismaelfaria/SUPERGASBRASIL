
using System.Text.Json.Serialization;
using SUPERGASBRASIL_API.Entities.Enum;

namespace SUPERGASBRASIL_API.Entities
{
    public class ClientLegalEntity
    {
        public Guid IdClientLegalEntity { get; set; }
        public string CompanyName { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SizeOfCompanies TypeOfCompany { get; set; }
        public string BusinessAddress { get; set; }
        public string TaxIdentificationNumberCNPJ { get; set; }
        public string ContactInformation { get; set; }
        public bool IsDeleted { get; set; }

        public ClientLegalEntity(string companyName, SizeOfCompanies typeOfCompany, string businessAddress, string taxIdentificationNumberCNPJ, string contactInformation)
        {
            CompanyName = companyName ?? throw new ArgumentNullException(nameof(companyName));
            TypeOfCompany = typeOfCompany;
            BusinessAddress = businessAddress ?? throw new ArgumentNullException(nameof(businessAddress));
            TaxIdentificationNumberCNPJ = taxIdentificationNumberCNPJ;
            ContactInformation = contactInformation;
            IsDeleted = false;
        }
        public void Update(string companyName, SizeOfCompanies typeOfCompany, string businessAddress, string taxIdentificationNumberCNPJ, string contactInformation)
        {
            CompanyName = companyName;
            TypeOfCompany = typeOfCompany;
            BusinessAddress = businessAddress;
            TaxIdentificationNumberCNPJ = taxIdentificationNumberCNPJ;
            ContactInformation = contactInformation;
        }
        public void Deleted()
        {
            IsDeleted = true;
        }
    }
}
