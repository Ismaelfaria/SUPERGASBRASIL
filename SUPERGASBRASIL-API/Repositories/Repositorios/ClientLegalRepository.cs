using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryClientLegal
{
    public class ClientLegalRepository : IClientLegalRepository
    {
        private readonly GasContext _context;

        public ClientLegalRepository(GasContext context)
        {
            _context = context;
        }

        public ClientLegalEntity CreateClientLegal(ClientLegalEntity clientLegal)
        {
            _context.ClientLegal.Add(clientLegal);
            _context.SaveChanges();

            return clientLegal;
        }
        public void DeleteClientLegal(Guid id)
        {
            var userDatabase = _context.ClientLegal.SingleOrDefault(a => a.IdClientLegalEntity == id);

            userDatabase.Deleted();
            _context.SaveChanges();
        }
        public IEnumerable<ClientLegalEntity> FindAll()
        {
            var usersDatabase = _context.ClientLegal.Where(a => !a.IsDeleted).ToList();

            return usersDatabase;
        }

        public ClientLegalEntity FindByCnpj(string cnpj)
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
            var userDatabase = _context.ClientLegal.SingleOrDefault(a => a.CompanyName == name);

            if (userDatabase == null)
            {
                return null;
            }

            return userDatabase;
        }
        public void UpdateClientLegal(string cnpj, ClientLegalEntity clientLegal)
        {
            var userDatabase = _context.ClientLegal.SingleOrDefault(a => a.TaxIdentificationNumberCNPJ == cnpj);

            userDatabase.Update(clientLegal.CompanyName, clientLegal.TypeOfCompany, clientLegal.BusinessAddress, clientLegal.TaxIdentificationNumberCNPJ, clientLegal.ContactInformation);
            _context.SaveChanges();
        }
    }
}
