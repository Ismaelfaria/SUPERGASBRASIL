using SUPERGASBRASIL_API.Entities;

namespace SUPERGASBRASIL_API.Repositories.Interfaces
{
    public interface IAdminRepository
    {
        void Create(Admin adm);
        void Delete(Guid id);
        IEnumerable<Admin> FindAll();
        Admin FindByUserName(string name);
        void Update(string userName, Admin adm);
    }
}
