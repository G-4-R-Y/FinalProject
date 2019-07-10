using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Persistence.Interfaces;
using Model.Models;
using System.Linq;

namespace Persistence.RepositoryFiles
{
    public class OwnerDAL : IDataAccessLayer<Owner>
    {
        private EFContext context;

        /*public Owner GetOwnerById (long ownerId)
        {
            using (var context = new EFContext())
            {
                try
                {
                    return context.tb_Owner.Where(owner => owner.OwnerId.Equals(ownerId)).FirstOrDefault();
                }
                catch
                {
                    throw new Exception("Não foi possível estabelecer uma conexão com o servidor");
                }
            }
        }*/

        public IList<Owner> ShowAll()
        {
            try
            {
                using (var context = new EFContext())
                {
                    return context.Owners.ToList<Owner>();
                }
            }
            catch
            {
                throw new Exception("Não foi possível acessar a base de dados.");
            }
        }

        public void Insert(Owner owner)
        {
            //insere
            //try
            {
                using (var context = new EFContext())
                {
                    context.Owners.Add(owner);

                    context.SaveChanges();
                }
            }
            //catch
            {
                //throw new Exception("Não foi possível adicionar o pet à base de dados.");
            }
        }

        public void Alter(Owner owner)
        {
            //altera
            //try
            {
                using (var context = new EFContext())
                {
                    context.Entry(owner).State = EntityState.Modified;

                    context.SaveChanges();
                }
            }
            //catch
            {
                //throw new Exception("Não foi possível alterar a base de dados.");
            }
        }

        public void Remove(long? ownerId)
        {
            //remove
            //try
            {
                if (ownerId != null)
                using (var context = new EFContext())
                {
                    var owner = context.Owners.Single(p => p.OwnerId == ownerId);
                    context.Owners.Remove(owner);
                    context.SaveChanges();
                }
            }
            //catch
            {
                //throw new Exception("Não foi possível remover da base de dados.");
            }
        }

        public Owner GetById(long? ownerId)
        {
            //recupera pelo Id
            try
            {
                using (var context = new EFContext())
                {
                    return context.Owners.Where(owner => owner.OwnerId.Equals(ownerId)).FirstOrDefault();
                }
            }
            catch
            {
                throw new Exception("Não foi possível modificar a base de dados.");
            }
        }
    }
}
