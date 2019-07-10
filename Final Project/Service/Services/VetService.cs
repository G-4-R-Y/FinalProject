using System;
using System.Collections.Generic;
using System.Text;
using Persistence.RepositoryFiles;
using Model.Models;

namespace Service.Services
{
    public class VetService : ServiceGeneric<Vet>
    {
        private VetDAL vetDAL = new VetDAL();

        public override Vet GetById(long? vetId)
        {
            if (vetId < 0)
                return null;
            return vetDAL.GetById(vetId);
        }
    }
}
