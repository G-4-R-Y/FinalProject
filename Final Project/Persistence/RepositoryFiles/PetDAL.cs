using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using System.Linq;
using Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Persistence.RepositoryFiles
{
    public class PetDAL : RepositoryGeneric<Pet>, IDataAccessLayer<Pet>
    {
        private EFContext context;

        public override IList<Pet> ShowAll() {
            return base.ShowAll();
        }

        public IList<Pet> ShowAll(Owner owner)
        {
            try
            {
                using (var context = new EFContext())
                {
                    return context.Pets.Where(pet => pet.OwnerId == owner.OwnerId).ToList<Pet>();
                }
            }
            catch
            {
                throw new Exception("Não foi possível acessar a base de dados.");
            }
        }

        public override void Insert(Pet pet)
        {
            //para não dar erro no entity (tentando adicionar duas vezes a fk)
            if (pet.OwnerId != null)
                pet.OwnedBy = null;

            //insere
            //try
            {
                using (var context = new EFContext())
                {
                    context.Pets.Add(pet);

                    context.SaveChanges();
                }
            }
            //catch
            {
                //throw new Exception("Não foi possível adicionar o pet à base de dados.");
            }
        }

        public override void Alter(Pet pet)
        {
            //para não dar erro no entity (tentando adicionar duas vezes a fk)
            Owner petOwner = pet.OwnedBy;
            if (pet.OwnerId != null)
            {
                pet.OwnedBy = null;
            }

            //altera
            //try
            {
                using (var context = new EFContext())
                {
                    context.Entry(pet).State = EntityState.Modified;

                    context.SaveChanges();
                }
            }
            //catch
            {
                //throw new Exception("Não foi possível alterar a base de dados.");
            }

            pet.OwnedBy = petOwner;
        }
    }
}
