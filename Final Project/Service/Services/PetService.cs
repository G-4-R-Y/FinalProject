using System;
using System.Collections.Generic;
using System.Text;
using Service.Interfaces;
using Persistence.RepositoryFiles;
using Model.Models;

namespace Service.Services
{
    public class PetService : ServiceGeneric<Pet>, IService<Pet>
    {
        private PetDAL petDAL= new PetDAL();

        public IList<Pet> ShowAll(Owner owner)
        {
            if (owner == null)
                return null;
            return petDAL.ShowAll(owner);
        }

        public override void Insert(Pet pet)
        {
            petDAL.Insert(pet);
        }

        public override void Alter(Pet pet)
        {
            petDAL.Alter(pet);
        }
    }
}