using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientLegal;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesClientLegal
{
    public class Create : ICreate
    {
        private readonly GasContext _context;
        public Create(GasContext context)
        {
            _context = context;
        }
        public void CreateClientLegal(ClientLegalEntity clientLegal)
        {
            _context.ClientLegal.Add(clientLegal);
            _context.SaveChanges();
        }
    }
}
