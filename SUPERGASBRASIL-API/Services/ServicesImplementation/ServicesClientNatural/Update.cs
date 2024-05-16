using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientNatural;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesClientNatural
{
    public class Update : IUpdate
    {
        private readonly GasContext _context;
        public Update(GasContext context)
        {
            _context = context;
        }
        public void UpdateClientNatural(int cpf, ClientNaturalPerson clientNatural)
        {
            var userDatabase = _context.ClientNatural.SingleOrDefault(a => a.CPF == cpf);

            userDatabase.Update(clientNatural.Name, clientNatural.Age, clientNatural.DateOfBirth, clientNatural.CPF);
            _context.SaveChanges();
        }
    }
}
