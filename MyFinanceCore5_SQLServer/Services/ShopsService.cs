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
    public class ShopsService : BaseRepository<Shop>, IShopsService
    {
        private AppDbContext _context;
        private int userId;
        public ShopsService(AppDbContext context) : base(context)
        {
            _context = context;
            userId = 1;
        }

        public async Task<IEnumerable<Shop>> GetShopAll()
        {
            var data = await _context.Shops
                .Include(u => u.User)
                .Include(u => u.Payment)
                .Include(u => u.CardUser)
                .Include(p => p.Payment).ThenInclude(i => i.TypePayment).ThenInclude(c => c.PictureIcon)
                .ToListAsync();


            return data;
        }
    }
}
