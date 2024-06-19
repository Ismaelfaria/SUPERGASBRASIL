
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using SUPERGASBRASIL_API.Entities.Enum;
using SUPERGASBRASIL_API.Rest.DTO;
using SUPERGASBRASIL_API.Rest.Model;

namespace SUPERGASBRASIL_API.Entities
{
    public class ClientLegalEntity
    {
        public ClientLegalEntity()
        {
            IdClientLegalEntity = Guid.NewGuid();
        }
        public Guid IdClientLegalEntity { get; set; }
        public string Name { get; set; }
        public long TaxIdentificationNumberCNPJ { get; set; }

        [NotMapped]
        public CnpjModel CnpjInfo { get; set; }
        public int ContactInformation { get; set; }
        public bool IsDeleted { get; set; }

        public ClientLegalEntity(string Name, long taxIdentificationNumberCNPJ, int contactInformation)
        {
            Name = Name ?? throw new ArgumentNullException(nameof(Name));
            TaxIdentificationNumberCNPJ = taxIdentificationNumberCNPJ;
            ContactInformation = contactInformation;
            IsDeleted = false;
        }
        public void Update(string Name, long taxIdentificationNumberCNPJ, int contactInformation)
        {
            Name = Name;
            TaxIdentificationNumberCNPJ = taxIdentificationNumberCNPJ;
            ContactInformation = contactInformation;
        }
        public void Deleted()
        {
            IsDeleted = true;
        }
    }
}
