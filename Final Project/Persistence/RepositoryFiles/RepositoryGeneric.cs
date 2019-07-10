using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Persistence.Interfaces;

namespace Persistence.RepositoryFiles
{
    public class RepositoryGeneric<T> : IDataAccessLayer<T> where T : class
    {
        private EFContext context;

        public virtual long GetId(T t)
        {
            //recupera a primary key (ou seja, o Id) de uma entidade qualquer t na base de dados
            using (var context = new EFContext())
            {
                var keyName = context.Model.FindEntityType(typeof(T)).FindPrimaryKey().Properties.Select(x => x.Name).Single();

                return (long)t.GetType().GetProperty(keyName).GetValue(t, null);
            }
        }

        public virtual IList<T> ShowAll()
        {
            //try
            {
                using (var context = new EFContext())
                {
                    var dbSet = context.Set<T>().ToList<T>();
                    return dbSet;
                }
            }
            //catch
            {
                //throw new Exception("Não foi possível acessar a base de dados.");
            }
        }

        public virtual void Insert(T t)
        {
            //insere
            //try
            {
                using (var context = new EFContext())
                {
                    context.Set<T>().Add(t);

                    context.SaveChanges();
                }
            }
            //catch
            {
                //throw new Exception("Não foi possível adicionar o pet à base de dados.");
            }
        }

        public virtual void Alter(T t)
        {
            //altera
            //try
            {
                using (var context = new EFContext())
                {
                    context.Entry(t).State = EntityState.Modified;

                    context.SaveChanges();
                }
            }
            //catch
            {
                //throw new Exception("Não foi possível alterar a base de dados.");
            }
        }

        public virtual void Remove(long? tId)
        {
            //remove
            //try
            {
                using (var context = new EFContext())
                {
                    var t = context.Set<T>().Single(ttt => GetId(ttt) == tId);
                    context.Set<T>().Remove(t);
                    context.SaveChanges();
                }
            }
            //catch
            {
                //throw new Exception("Não foi possível remover da base de dados.");
            }
        }

        public virtual T GetById(long? tId)
        {
            //recupera pelo Id
            try
            {
                using (var context = new EFContext())
                {
                    return context.Set<T>().Where(t => GetId(t) == tId).FirstOrDefault();
                }
            }
            catch
            {
                throw new Exception("Não foi possível modificar a base de dados.");
            }
        }
    }
}
