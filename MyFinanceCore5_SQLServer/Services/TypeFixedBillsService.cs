using MyFinanceCore5_SQLServer.Data;
using MyFinanceCore5_SQLServer.Models.Entity;
using MyFinanceCore5_SQLServer.Models.Interfaces;
using MyFinanceCore5_SQLServer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Services
{
    public class TypeFixedBillsService : BaseRepository<TypeFixedBill>, ITypeFixedBillsService
    {
        public TypeFixedBillsService(AppDbContext context) : base(context)
        {
        }
    }
}
