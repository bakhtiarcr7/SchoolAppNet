using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Repositoies
{
    public interface IRepository<TEntity> where TEntity : class
    {

        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

      
        //Add Entity Methods
        void Add(TEntity entity);
        //Update Entity
        void Update(TEntity entity);

        //Remove Entity Methods
        void Remove(TEntity entity);

    }
}
