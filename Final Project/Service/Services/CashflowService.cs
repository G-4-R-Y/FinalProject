using System;
using System.Collections.Generic;
using System.Text;
using Persistence.RepositoryFiles;
using Service.Interfaces;
using Model.Models;

namespace Service.Services
{
    class CashflowService : ServiceGeneric<Cashflow>, IService<Cashflow>
    {
        private CashflowDAL cashflowDAL = new CashflowDAL();


    }
}
