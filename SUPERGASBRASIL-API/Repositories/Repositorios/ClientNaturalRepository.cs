using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces;

namespace SUPERGASBRASIL_API.Repositories.Repositorios.RepositoryClientNatural
{
    public class ClientNaturalRepository : IClientNaturalRepository
    {
        private readonly GasContext _context;

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
            throw new NotImplementedException();
        }

        public ClientNaturalPerson FindByCpf(int cpf)
        {
            throw new NotImplementedException();
        }

        public ClientNaturalPerson FindByName(string name)
        {
            throw new NotImplementedException();
        }
        public void UpdateClientNatural(int cpf, ClientNaturalPerson clientNatural)
        {
            var userDatabase = _context.ClientNatural.SingleOrDefault(a => a.CPF == cpf);

            userDatabase.Update(clientNatural.Name, clientNatural.Age, clientNatural.DateOfBirth, clientNatural.CPF);
            _context.SaveChanges();
        }

    }
}
