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


        public async Task<IEnumerable<TypePayment>> GetAllWthPictureAsync()
        {
            var list = await _context.TypePayments
                .Include(obj => obj.PictureIcon)
                .Include(obj => obj.User)
                .ToListAsync();
            return await Task.FromResult<List<TypePayment>>(list);
        }

        public async Task<TypePayment> GetByIdWithPictureAsync(int id)
        {
            return await _context.TypePayments
                .Include(p => p.PictureIcon)
                .Include(u => u.User)
                .FirstOrDefaultAsync(n => n.Id == id);
        }

    }
}


