using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientNatural;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesClientNatural
{
    public class Create : ICreate
    {
        private readonly GasContext _context;
        public Create(GasContext context)
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
