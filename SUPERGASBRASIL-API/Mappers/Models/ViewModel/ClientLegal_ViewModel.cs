namespace SUPERGASBRASIL_API.Mappers.Models.ViewModel
{
    public class ClientLegal_ViewModel
    {
        public Guid IdClientLegalEntity { get; set; }
        public string CompanyName { get; set; }
        public string TypeOfCompany { get; set; }
        public string BusinessAddress { get; set; }
        public int TaxIdentificationNumberCNPJ { get; set; }
        public int ContactInformation { get; set; }
        public bool IsDeleted { get; set; }
    }
}
