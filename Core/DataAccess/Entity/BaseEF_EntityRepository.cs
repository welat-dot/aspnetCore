using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Core.DataAccess.Entity
{
    public class BaseEF_EntityRepository<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
         where TContext : DbContext, new()
    {

        private TContext Context;

        public BaseEF_EntityRepository(TContext Context)
        {
            this.Context = Context;
        }
        public  TEntity Get(Expression<Func<TEntity, bool>> filter)
        {

            return  Context.Set<TEntity>().FirstOrDefault(filter);
           

        }

        public  IQueryable<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {


            if(filter==null)
            {
                return Context.Set<TEntity>();
                
            }
            return Context.Set<TEntity>().Where(filter);
             

        }

        public void Add(TEntity Entity)
        {
           var x= Context.Set<TEntity>().Add(Entity);
            Context.SaveChanges();            

        }

        public void Update(TEntity Entity)
        {
           
                Context.Set<TEntity>().Update(Entity);
                Context.SaveChanges();
         

        }

        public void Delete(TEntity Entity)
        {
           
                Context.Set<TEntity>().Remove(Entity);
                Context.SaveChanges();
            

        }
    }
}
