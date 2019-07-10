using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using System.Linq;
using Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Persistence.RepositoryFiles
{
    public class SaleDAL : RepositoryGeneric<Sale>, IDataAccessLayer<Sale>
    {
        private EFContext context;
    }
}
