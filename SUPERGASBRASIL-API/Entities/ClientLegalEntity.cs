
using System.Text.Json.Serialization;
using SUPERGASBRASIL_API.Entities.Enum;

namespace SUPERGASBRASIL_API.Entities
{
    public class ClientLegalEntity
    {
        public ClientLegalEntity()
        {
            IdClientLegalEntity = Guid.NewGuid();
        }
        public Guid IdClientLegalEntity { get; set; }
        public string CompanyName { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ESizeOfCompanies TypeOfCompany { get; set; }
        public string TypeCompany { get; set; }
        public string BusinessAddress { get; set; }
        public long TaxIdentificationNumberCNPJ { get; set; }
        public int ContactInformation { get; set; }
        public bool IsDeleted { get; set; }

        public ClientLegalEntity(string companyName, ESizeOfCompanies typeOfCompany, string businessAddress, long taxIdentificationNumberCNPJ, int contactInformation)
        {
            CompanyName = companyName ?? throw new ArgumentNullException(nameof(companyName));
            TypeOfCompany = typeOfCompany;
            BusinessAddress = businessAddress ?? throw new ArgumentNullException(nameof(businessAddress));
            TaxIdentificationNumberCNPJ = taxIdentificationNumberCNPJ;
            ContactInformation = contactInformation;
            IsDeleted = false;
        }
        public void Update(string companyName, ESizeOfCompanies typeOfCompany, string businessAddress, long taxIdentificationNumberCNPJ, int contactInformation)
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
