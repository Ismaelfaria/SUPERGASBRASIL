using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces;

namespace SUPERGASBRASIL_API.Repositories.Repositorios
{
    public class ClientLegalEntityRepository : IClientLegalEntityRepository
    {
        private readonly GasContext _context;
        public ClientLegalEntityRepository(GasContext context)
        {
            _context = context;
        }
        public void Create(ClientLegalEntity clientLegal)
        {
            _context.ClientLegal.Add(clientLegal);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
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

        public ClientLegalEntity FindByCnpj(int cnpj)
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

        public void Update(int cnpj, ClientLegalEntity clientLegal)
        {
            var userDatabase = _context.ClientLegal.SingleOrDefault(a => a.TaxIdentificationNumberCNPJ == cnpj);

            userDatabase.Update(clientLegal.CompanyName, clientLegal.TypeOfCompany, clientLegal.BusinessAddress, clientLegal.TaxIdentificationNumberCNPJ, clientLegal.ContactInformation);
            _context.SaveChanges();
        }
    }
}
