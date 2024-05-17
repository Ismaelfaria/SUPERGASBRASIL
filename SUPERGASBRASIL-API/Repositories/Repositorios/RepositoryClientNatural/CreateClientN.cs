using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientNatural;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryClientNatural
{
    public class CreateClientN : ICreateClientN
    {
        private readonly GasContext _context;
        public CreateClientN(GasContext context)
        {
            _context = context;
        }
        public void CreateClientNatural(ClientNaturalPerson clientNatural)
        {
            _context.ClientNatural.Add(clientNatural);
            _context.SaveChanges();
        }

    }
}
