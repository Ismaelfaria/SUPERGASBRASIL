using SUPERGASBRASIL_API.Entities;
using SUPERGASBRASIL_API.Repositories.Interfaces.InterfaceSales;
using SUPERGASBRASIL_API.Services.Interfaces.InterfaceSales;


namespace SUPERGASBRASIL_API.Services.ServicesImplementation.ServicesSales
{
    public class GetSS : IGetServS
    {
        private readonly IGetS GetS;
        public GetSS(IGetS getS)
        {
            GetS = getS;
        }
        public IEnumerable<Sales> FindAll()
        {
            var usersDatabase = GetS.FindAll();

            return usersDatabase;
        }

        public Sales FindByDateSale(DateTime timeOfSale)
        {
            var usersDatabase = GetS.FindByDateSale(timeOfSale);

            return usersDatabase;
        }

        public Sales FindById(Guid id)
        {
            var usersDatabase = GetS.FindById(id);

            return usersDatabase;
        }
    }
}
