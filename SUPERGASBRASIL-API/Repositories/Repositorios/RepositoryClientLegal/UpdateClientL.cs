using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientLegal;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryClientLegal
{
    public class UpdateClientL : IUpdateClientL
    {
        private readonly GasContext _context;
        public UpdateClientL(GasContext context)
        {
            _context = context;
        }
        public void UpdateClientLegal(int cnpj, ClientLegalEntity clientLegal)
        {
            var userDatabase = _context.ClientLegal.SingleOrDefault(a => a.TaxIdentificationNumberCNPJ == cnpj);

            userDatabase.Update(clientLegal.CompanyName, clientLegal.TypeOfCompany, clientLegal.BusinessAddress, clientLegal.TaxIdentificationNumberCNPJ, clientLegal.ContactInformation);
            _context.SaveChanges();
        }
    }
}
