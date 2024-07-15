using SUPERGASBRASIL_API.App.Interfaces;
using SUPERGASBRASIL_API.Domain;
using SUPERGASBRASIL_API.Infra.Context;

namespace SUPERGASBRASIL_API.Infra.Repositorios
{
    public class ClientLegalRepository : RepositoryBase<ClientLegalEntity>
    {
        public ClientLegalRepository(GasContext context) : base(context)
        {
        }

        public ClientLegalEntity FindByCnpj(long cnpj)
        {
            var userDatabase = _context.ClientLegal.SingleOrDefault(a => a.TaxIdentificationNumberCNPJ == cnpj);

            if (userDatabase == null)
            {
                return null;
            }

            return userDatabase;
        }

        public ClientLegalEntity FindByCompanyName(string name)
        {
            var userDatabase = _context.ClientLegal.SingleOrDefault(a => a.Name == name);

            if (userDatabase == null)
            {
                return null;
            }

            return userDatabase;
        }
        public void UpdateClientLegal(long cnpj, ClientLegalEntity clientLegal)
        {
            var userDatabase = _context.ClientLegal.SingleOrDefault(a => a.TaxIdentificationNumberCNPJ == cnpj);

            userDatabase.Update(clientLegal.Name, clientLegal.TaxIdentificationNumberCNPJ, clientLegal.ContactInformation);
            _context.SaveChanges();
        }
    }
}
