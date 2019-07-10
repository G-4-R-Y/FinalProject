using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Persistence.RepositoryFiles;
using Service.Interfaces;

namespace Service.Services
{
    public class ServiceGeneric<T> : IService<T> where T : class
    {
        private RepositoryGeneric<T> repository = new RepositoryGeneric<T>();

        public virtual long? GetId(T t)
        {
            return Convert.ToInt64(repository.GetId(t));
        }

        public virtual IList<T> ShowAll()
        {
            return repository.ShowAll();
        }

        public virtual void Insert(T t)
        {
            repository.Insert(t);
        }

        public virtual void Alter(T t)
        {
            repository.Alter(t);
        }

        public virtual void Remove(long? tId)
        {
            repository.Remove(tId);
        }

        public virtual T GetById(long? tId)
        {
            return repository.GetById(tId);
        }
    }
}
