using School_Management_System.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System.Repositoies
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;
        public Repository(DbContext context)
        {
            Context = context;
        }

        public TEntity Get(int id)
        {

            return Context.Set<TEntity>().Find(id);

        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }



        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }



        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);

        }



        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

       
    }
}
