using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientLegal;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryClientLegal
{
    public class GetClientL : IGetClientL
    {
        private readonly GasContext _context;
        public GetClientL(GasContext context)
        {
            _context = context;
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

    }
}
