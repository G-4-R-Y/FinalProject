using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Persistence.RepositoryFiles;

namespace Service.Services
{
    public class AdressService : ServiceGeneric<Adress>
    {
        private AdressDAL adressDAL = new AdressDAL();

        public IList<Adress> ShowAll(Owner owner)
        {
            if (owner == null)
                return null;
            return adressDAL.ShowAll(owner);
        }

        public IList<Adress> ShowAll(Vet vet)
        {
            if (vet == null)
                return null;
            return adressDAL.ShowAll(vet);
        }

        public void InsertOwner(Adress adress)
        {
            adressDAL.InsertOwner(adress);
        }

        public void AlterOwner(Adress adress)
        {
            adressDAL.AlterOwner(adress);
        }

        public void InsertVet(Adress adress)
        {
            adressDAL.InsertVet(adress);
        }

        public void AlterVet(Adress adress)
        {
            adressDAL.AlterVet(adress);
        }
    }
}
