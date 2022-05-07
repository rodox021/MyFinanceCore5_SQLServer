using Microsoft.EntityFrameworkCore;
using MyFinanceCore5_SQLServer.Data;
using MyFinanceCore5_SQLServer.Models.Entity;
using MyFinanceCore5_SQLServer.Models.ViewModels;
using MyFinanceCore5_SQLServer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Services
{
    public class PaymentsService : BaseRepository<Payment>, IPaymentsService
    {
        private AppDbContext _context;
        private int userId;
        public PaymentsService(AppDbContext context) : base(context)
        {
            _context = context;
            userId = 1;
        }

        public async Task<Payment> GetByIdWithTypePaymentAsync(int id)
        {
            var list = await _context.Payments
                   .Include(tp => tp.TypePayment)
                   .Include(pi => pi.TypePayment.PictureIcon)
                 .Include(u => u.User)
                 .FirstOrDefaultAsync(n => n.Id == id);

            return list;
        }

        public async Task<NewPaymentDropDownViewModel> GetDropDown()
        {

            var data = new NewPaymentDropDownViewModel();
            data.TypePayments = await _context.TypePayments.OrderBy(n => n.FlagCard).ToListAsync();

            return data;
        }

        public async Task<IEnumerable<Payment>> GetPaymentAll()
        {
            var data = await _context.Payments
                .Include(tp => tp.TypePayment)
                .Include(p => p.TypePayment.PictureIcon)
                .Include(u => u.User)
                .Where(pay => pay.UserId == userId)
                .ToListAsync();

            return data;
        }


    }
}
