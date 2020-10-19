using Core.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity
    {
        T Get(Expression<Func<T, bool>> filter);
        IQueryable<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
    }
}
