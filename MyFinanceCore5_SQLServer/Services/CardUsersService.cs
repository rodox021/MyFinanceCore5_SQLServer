using MyFinanceCore5_SQLServer.Data;
using MyFinanceCore5_SQLServer.Models.Entity;
using MyFinanceCore5_SQLServer.Models.Interfaces;
using MyFinanceCore5_SQLServer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Services
{
    public class CardUsersService : BaseRepository<CardUser>, ICardUsersService
    {
        private AppDbContext _context;
        private int userId;
        public CardUsersService(AppDbContext context) : base(context)
        {
            _context = context;
            userId = 1;
        }
    }
}
