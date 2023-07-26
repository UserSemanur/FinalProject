using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;

namespace Core.DataAccess
{
    public  interface IEntityRepository<T> where T : class, IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter );

        void Add(T entity);
        void Update(T entityt);
        void Delete(T entity);
      

    }
}
