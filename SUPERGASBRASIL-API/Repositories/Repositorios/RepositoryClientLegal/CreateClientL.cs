using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientLegal;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryClientLegal
{
    public class CreateClientL : ICreateClientL
    {
        private readonly GasContext _context;
        public CreateClientL(GasContext context)
        {
            _context = context;
        }
        public ClientLegalEntity CreateClientLegal(ClientLegalEntity clientLegal)
        {
            _context.ClientLegal.Add(clientLegal);
            _context.SaveChanges();

            return clientLegal;
        }
    }
}
