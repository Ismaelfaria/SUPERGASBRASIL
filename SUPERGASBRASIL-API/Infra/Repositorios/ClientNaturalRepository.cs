using SUPERGASBRASIL_API.App.Interfaces;
using SUPERGASBRASIL_API.Domain;
using SUPERGASBRASIL_API.Infra.Context;

namespace SUPERGASBRASIL_API.Infra.Repositorios
{
    public class ClientNaturalRepository : IClientNaturalRepository
    {
        private readonly GasContext _context;

        public ClientNaturalRepository(GasContext context)
        {
            _context = context;
        }

        public ClientNaturalPerson CreateClientNatural(ClientNaturalPerson clientNatural)
        {
            _context.ClientNatural.Add(clientNatural);
            _context.SaveChanges();

            return clientNatural;
        }
        public void DeleteClientNatural(Guid id)
        {
            var userDatabase = _context.ClientNatural.SingleOrDefault(a => a.IdClientNaturalPerson == id);

            userDatabase.Deleted();
            _context.SaveChanges();
        }
        public IEnumerable<ClientNaturalPerson> FindAll()
        {
            var usersDatabase = _context.ClientNatural.Where(a => !a.IsDeleted).ToList();

            return usersDatabase;
        }

        public ClientNaturalPerson FindByCpf(string cpf)
        {
            var userDatabase = _context.ClientNatural.SingleOrDefault(a => a.CPF == cpf);

            if (userDatabase == null)
            {
                return null;
            }

            return userDatabase;
        }

        public ClientNaturalPerson FindByName(string name)
        {
            var userDatabase = _context.ClientNatural.SingleOrDefault(a => a.Name == name);

            if (userDatabase == null)
            {
                return null;
            }

            return userDatabase;
        }
        public void UpdateClientNatural(string cpf, ClientNaturalPerson clientNatural)
        {
            var userDatabase = _context.ClientNatural.SingleOrDefault(a => a.CPF == cpf);

            userDatabase.Update(clientNatural.Name, clientNatural.Age, clientNatural.DateOfBirth, clientNatural.CPF);
            _context.SaveChanges();
        }

    }
}
