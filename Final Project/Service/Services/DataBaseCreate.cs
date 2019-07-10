using System;
using System.Collections.Generic;
using System.Text;
using Persistence.RepositoryFiles;

namespace Service.Services
{
    public class DataBaseCreate
    {
        public static void CreateDataBase()
        {
            using (EFContext context = new EFContext())
            {
                //context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
        }
    }
}
