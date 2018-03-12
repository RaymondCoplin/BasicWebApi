using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebApi.Services
{
    interface IService<T>
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
