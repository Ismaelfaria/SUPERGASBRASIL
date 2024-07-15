using SUPERGASBRASIL_API.App.Interfaces;
using SUPERGASBRASIL_API.Domain;
using SUPERGASBRASIL_API.Infra.Context;

namespace SUPERGASBRASIL_API.Infra.Repositorios
{
    public class ClientNaturalRepository : RepositoryBase<Employees>
    {
        public ClientNaturalRepository(GasContext context) : base(context)
        {
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
