using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Model;

namespace CoffeeShop.Orm.Repositories
{
    public interface IEntityRepository<TEntity>
        where TEntity : IEntityBase
    {
        List<TEntity> GetAll();
        TEntity? GetById(Guid id);
        void Add(TEntity entity);
        void Update(Guid id, TEntity entity);
        void Delete(Guid id);
    }
}
