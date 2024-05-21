using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Repositories.Interfaces;
using SUPERGASBRASIL_API.Services.Interfaces;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation
{
    public class ClientNaturalService : IClientNaturalService
    {
        private readonly IClientNaturalRepository client;

        public ClientNaturalService(IClientNaturalRepository client)
        {
            this.client = client;
        }

        public ClientNaturalPerson CreateClientNatural(ClientNaturalPerson clientNatural)
        {
            client.CreateClientNatural(clientNatural);

            return clientNatural;
        }
        public void DeleteClientNatural(Guid id)
        {
            client.DeleteClientNatural(id);
        }
        public IEnumerable<ClientNaturalPerson> FindAll()
        {
            var usersDatabase = client.FindAll();

            return usersDatabase;
        }

        public ClientNaturalPerson FindByCpf(int cpf)
        {
            var usersDatabase = client.FindByCpf(cpf);

            return usersDatabase;
        }

        public ClientNaturalPerson FindByName(string name)
        {
            var usersDatabase = client.FindByName(name);

            return usersDatabase;
        }
        public void UpdateClientNatural(int cpf, ClientNaturalPerson clientNatural)
        {
            client.UpdateClientNatural(cpf, clientNatural);
        }
    }
}
