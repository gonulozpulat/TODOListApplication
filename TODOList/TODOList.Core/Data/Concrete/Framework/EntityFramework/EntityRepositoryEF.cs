using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TODOList.Core.Data.Abstract;
using TODOList.Core.Entities;
using System.Data.Entity.Infrastructure;

namespace TODOList.Core.Data.Concrete.Framework.EntityFramework
{
    public class EntityRepositoryEF<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
    {
        public TEntity GetById(int id)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> expression)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(expression);
            }
        }

        public IList<TEntity> GetAll(Expression<Func<TEntity, bool>> expression)
        {
            using (TContext context = new TContext())
            {
                if (expression != null)
                {
                    return context.Set<TEntity>().Where(expression).ToList();
                }
                else
                {
                    return context.Set<TEntity>().ToList();
                }
            }
        }

        public TEntity Add(TEntity entity)
        {
            using(TContext context = new TContext())
            {
                DbEntityEntry<TEntity> addEntity = context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.SaveChanges();
                return entity;
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                DbEntityEntry updateEntity = context.Entry(entity);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();
                return entity;
            }
        }

        public void Delete(TEntity entity)
        {
            using(TContext context = new TContext())
            {
                DbEntityEntry deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }        

        
    }
}
