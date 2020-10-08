
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Core.DataAccess.Entity
{
    public class BaseEF_EntityRepository<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
        where TContext : DbContext,new()
    {
        

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using(var context =new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(filter);
            }
            
        }

        public IQueryable<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ?
                context.Set<TEntity>() :
                context.Set<TEntity>().Where(filter);
            }
           

        }

        public void Add(TEntity Entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Add(Entity);
                context.SaveChanges();
            }
            
        }

        public void Update(TEntity Entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Update(Entity);
                context.SaveChanges();
            }
           
        }

        public void Delete(TEntity Entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Remove(Entity);
                context.SaveChanges();
            }
           
        }
    }
}
