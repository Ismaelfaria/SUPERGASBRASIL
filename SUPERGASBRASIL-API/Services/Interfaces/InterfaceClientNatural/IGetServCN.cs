using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Services.Interfaces.InterfaceClientNatural
{
    public interface IGetServCN
    {
        IEnumerable<ClientNaturalPerson> FindAll();
        ClientNaturalPerson FindByCpf(int cpf);
        ClientNaturalPerson FindByName(string name);
    }
}
