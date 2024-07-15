using SUPERGASBRASIL_API.Domain;

namespace SUPERGASBRASIL_API.App.InterfacesRep
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        TEntity Create(TEntity entity);
        void Delete(Guid id);
    }
}
