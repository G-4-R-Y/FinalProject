using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using System.Linq;
using Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Persistence.RepositoryFiles
{
    public class SaleProductDAL : RepositoryGeneric<SaleProduct>, IDataAccessLayer<SaleProduct>
    {
        private EFContext context;


    }
}
