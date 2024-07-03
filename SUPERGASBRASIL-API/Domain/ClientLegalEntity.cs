
using System.ComponentModel.DataAnnotations.Schema;
using SUPERGASBRASIL_API.App.Rest.Model;

namespace SUPERGASBRASIL_API.Domain
{
    public class ClientLegalEntity
    {
        public ClientLegalEntity()
        {
            IsDeleted = false;
        }
        public Guid IdClientLegalEntity { get; set; }
        public string Name { get; set; }
        public long TaxIdentificationNumberCNPJ { get; set; }

        [NotMapped]
        public CnpjModel CnpjInfo { get; set; }
        public int ContactInformation { get; set; }
        public bool IsDeleted { get; set; }
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
