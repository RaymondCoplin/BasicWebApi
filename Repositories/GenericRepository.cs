using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BasicWebApi.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T: class
    {
        private DbContext _Context;
        private DbSet<T> _DbSet;

        public GenericRepository(DbContext ctx)
        {
            _Context = ctx;
            _DbSet = ctx.Set<T>();
        }

        public T Create(T entity)
        {
            entity = _DbSet.Add(entity);
            _Context.SaveChanges();
            return entity;
        }
        
        public void Delete(T entity)
        {
            _DbSet.Remove(entity);
            _Context.SaveChanges();
        }

        public bool Exist(int id)
        {
            return this.Find(id) != null;
        }

        public T Find(int id)
        {
            return _DbSet.Find(id);
        }

        public IQueryable<T> FindAll()
        {
            return _DbSet;
        }

        public T Update(T entity)
        {
            _DbSet.Attach(entity);
            _Context.Entry(entity).State = EntityState.Modified;
            _Context.SaveChanges();

            return entity;
        }

        public void Dispose()
        {
            _Context.Dispose();
        }

    }
}