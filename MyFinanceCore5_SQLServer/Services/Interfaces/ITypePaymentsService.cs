using MyFinanceCore5_SQLServer.Models.Entity;
using MyFinanceCore5_SQLServer.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Services.Interfaces
{
    public interface ITypePaymentsService : IBaseRepository<TypePayment>
    {
    }
}
