using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Services.Exception
{
    public class DbConcurrencyExceptionService : ApplicationException
    {
        public DbConcurrencyExceptionService(string message) : base(message)
        {
        }
    }
}
