using System;
using System.Collections.Generic;
using System.Text;
using Service.Interfaces;
using Persistence.RepositoryFiles;
using Model.Models;

namespace Service.Services
{
    class StorageService : ServiceGeneric<Storage>, IService<Storage>
    {
        private StorageDAL storageDAL = new StorageDAL();


    }
}
