using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebApi.Repositories
{
    interface IRepository<T>
    {
        IQueryable<T> FindAll();
        T Find(int id);
        T Create(T entity);
        T Update(T entity);
        void Delete(T entity);
        bool Exist(int id);
        void Dispose();
    }
}
