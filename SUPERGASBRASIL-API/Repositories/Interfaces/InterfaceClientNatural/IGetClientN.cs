using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceClientNatural
{
    public interface IGetClientN
    {
        IEnumerable<ClientNaturalPerson> FindAll();
        ClientNaturalPerson FindByCpf(int cpf);
        ClientNaturalPerson FindByName(string name);
    }
}
