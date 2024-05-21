using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Services.Interfaces;

namespace SUPERGASBRASIL_API.Services.ServicesImplementation
{
    public class ClientLegalService : IClientLegalService
    {
        private readonly IClientLegalService client;

        public ClientLegalService(IClientLegalService client)
        {
            this.client = client;
        }

        public ClientLegalEntity CreateClientLegal(ClientLegalEntity clientLegal)
        {
            client.CreateClientLegal(clientLegal);

            return clientLegal;
        }
        public void DeleteClientLegal(Guid id)
        {
            client.DeleteClientLegal(id);
        }
        public IEnumerable<ClientLegalEntity> FindAll()
        {
            var usersDatabase = client.FindAll();

            return usersDatabase;
        }

        public ClientLegalEntity FindByCnpj(int cnpj)
        {
            var usersDatabase = client.FindByCnpj(cnpj);

            return usersDatabase;
        }

        public ClientLegalEntity FindByCompanyName(string name)
        {
            var usersDatabase = client.FindByCompanyName(name);

            return usersDatabase;
        }
        public void UpdateClientLegal(int cnpj, ClientLegalEntity clientLegal)
        {
            client.UpdateClientLegal(cnpj, clientLegal);
        }
    }
}
