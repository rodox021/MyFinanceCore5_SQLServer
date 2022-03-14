using MyFinanceCore5_SQLServer.Data;
using MyFinanceCore5_SQLServer.Models.Entity;
using MyFinanceCore5_SQLServer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Services
{
    public class TypeInputsService : BaseRepository<TypeInput>, ITypeInputsService
    {
        public TypeInputsService(AppDbContext context) : base(context)
        {
        }
    }
}
