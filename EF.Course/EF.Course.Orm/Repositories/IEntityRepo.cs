using EF.Course.Model;

namespace EF.Course.Orm.Repositories
{
    public interface IEntityRepo<TEntity>
        where TEntity : IEntityBase
    {
        IList<TEntity> GetAll();
        TEntity? GetById(int id);
        void Add(TEntity entity);
        void Update(int id, TEntity entity);
        void Delete(int id);
    }
}
