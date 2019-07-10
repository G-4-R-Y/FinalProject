using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using System.Linq;
using Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Persistence.RepositoryFiles
{
    public class AdressDAL : RepositoryGeneric<Adress>, IDataAccessLayer<Adress>
    {
        private EFContext context;

        public override IList<Adress> ShowAll()
        {
            return base.ShowAll();
        }

        public IList<Adress> ShowAll(Owner owner)
        {
            try
            {
                using (var context = new EFContext())
                {
                    return context.Adresses.Where(adress => adress.OwnerId == owner.OwnerId).ToList<Adress>();
                }
            }
            catch
            {
                return null;
            }
        }

        public IList<Adress> ShowAll(Vet vet)
        {
            try
            {
                using (var context = new EFContext())
                {
                    return context.Adresses.Where(adress => adress.VetId == vet.VetId).ToList<Adress>();
                }
            }
            catch
            {
                throw new Exception("Não foi possível acessar a base de dados.");
            }
        }

        public void InsertOwner(Adress adress)
        {
            //para não dar erro no entity (tentando adicionar duas vezes a fk)
            if (adress.OwnerId != null)  
                adress.Owner = null;

            //insere
            //try
            {
                using (var context = new EFContext())
                {
                    context.Adresses.Add(adress);

                    context.SaveChanges();
                }
            }
            //catch
            {
                //throw new Exception("Não foi possível adicionar o pet à base de dados.");
            }
        }

        public void InsertVet(Adress adress)
        {
            //para não dar erro no entity (tentando adicionar duas vezes a fk)
            if (adress.VetId != null)
                adress.Vet = null;

            //insere
            //try
            {
                using (var context = new EFContext())
                {
                    context.Adresses.Add(adress);

                    context.SaveChanges();
                }
            }
            //catch
            {
                //throw new Exception("Não foi possível adicionar o pet à base de dados.");
            }
        }

        public void AlterVet(Adress adress)
        {
            //para não dar erro no entity (tentando adicionar duas vezes a fk)
            Vet adressVet = adress.Vet;
            if (adress.VetId != null)
            {
                adress.Vet = null;
            }

            //altera
            //try
            {
                using (var context = new EFContext())
                {
                    context.Entry(adress).State = EntityState.Modified;

                    context.SaveChanges();
                }
            }
            //catch
            {
                //throw new Exception("Não foi possível alterar a base de dados.");
            }

            adress.Vet = adressVet;
        }

        public void AlterOwner(Adress adress)
        {
            //para não dar erro no entity (tentando adicionar duas vezes a fk)
            if (adress.OwnerId != null)
                adress.Owner = null;

            //altera
            //try
            {
                using (var context = new EFContext())
                {
                    context.Entry(adress).State = EntityState.Modified;

                    context.SaveChanges();
                }
            }
            //catch
            {
                //throw new Exception("Não foi possível alterar a base de dados.");
            }
        }

        public IList<Adress> ShowAllOwner(long? ownerId)
        {
            using (var context = new EFContext())
            {
                return context.Adresses.Where(a => a.OwnerId == ownerId).ToList<Adress>();
            }
        }

        public IList<Adress> ShowAllVet(long? vetId)
        {
            using (var context = new EFContext())
            {
                return context.Adresses.Where(a => a.VetId == vetId).ToList<Adress>();
            }
        }
    }
}
