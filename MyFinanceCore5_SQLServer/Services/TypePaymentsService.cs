using Microsoft.EntityFrameworkCore;
using MyFinanceCore5_SQLServer.Data;
using MyFinanceCore5_SQLServer.Models.Entity;
using MyFinanceCore5_SQLServer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Services
{
    public class TypePaymentsService : BaseRepository<TypePayment>, ITypePaymentsService
    {
        private readonly AppDbContext _context;
        public TypePaymentsService(AppDbContext context) : base(context){

            _context = context;
        }

        public override async Task<IEnumerable<TypePayment>> GetAllAsync()
        {
           
            var list = await _context.TypePayments.Include(obj => obj.PictureIcon).ToListAsync();
            return await Task.FromResult<List<TypePayment>>(list);
        }
    }
}


