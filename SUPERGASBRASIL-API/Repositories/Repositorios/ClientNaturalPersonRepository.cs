using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Persistence.Context;
using SUPERGASBRASIL_API.Repositories.Interfaces;

namespace SUPERGASBRASIL_API.Repositories.Repositorios
{
    public class ClientNaturalPersonRepository : IClientNaturalPersonRepository

    {
        private readonly GasContext _context;
        public ClientNaturalPersonRepository(GasContext context)
        {
            _context = context;
        }
        public void Create(ClientNaturalPerson clientNatural)
        {
            _context.ClientNatural.Add(clientNatural);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
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

        public void Update(int cpf, ClientNaturalPerson clientLegal)
        {
            throw new NotImplementedException();
        }
    }
}
