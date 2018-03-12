using BasicWebApi.Models;
using BasicWebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicWebApi.Services
{
    public class ContactService: IService<Contact>
    {

        private GenericRepository<Contact> _repository;

        public ContactService()
        {
            _repository = new GenericRepository<Contact>(new ContactContext());
        }

        public Contact Create(Contact entity)
        {
            return _repository.Create(entity);
        }

        public void Delete(Contact entity)
        {
            _repository.Delete(entity);
        }

        public bool Exist(int id)
        {
            return _repository.Exist(id);
        }

        public Contact Find(int id)
        {
            return _repository.Find(id);
        }

        public IQueryable<Contact> FindAll()
        {
            return _repository.FindAll();
        }

        public Contact Update(Contact entity)
        {
            return _repository.Update(entity);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}