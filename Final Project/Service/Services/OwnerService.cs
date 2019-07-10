using System;
using System.Collections.Generic;
using System.Text;
using Persistence.RepositoryFiles;
using Model.Models;

namespace Service.Services
{
    public class OwnerService : ServiceGeneric<Owner>
    {
        private OwnerDAL ownerDAL = new OwnerDAL();
        
        public override Owner GetById(long? ownerId)
        {
            if (ownerId < 0)
                return null;
            return ownerDAL.GetById(ownerId);
        }
    }
}
