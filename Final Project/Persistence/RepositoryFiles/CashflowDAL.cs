using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using System.Linq;
using Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Persistence.RepositoryFiles
{
    public class CashflowDAL : RepositoryGeneric<Cashflow>, IDataAccessLayer<Cashflow>
    {
        private EFContext context;


    }
}
