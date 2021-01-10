using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TODOList.Core.Entities;

namespace TODOList.Core.Data.Abstract
{
    public interface IEntityRepository<T> where T: class,IEntity,new()
    {
        T GetById(int id);
        T Get(Expression<Func<T, bool>> expression);
        IList<T> GetAll(Expression<Func<T, bool>> expression);     
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);        
    }
}
