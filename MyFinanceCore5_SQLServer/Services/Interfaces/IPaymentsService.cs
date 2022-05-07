using MyFinanceCore5_SQLServer.Models.Entity;
using MyFinanceCore5_SQLServer.Models.Interfaces;
using MyFinanceCore5_SQLServer.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Services.Interfaces
{
    public interface IPaymentsService: IBaseRepository<Payment>
    {

        Task<IEnumerable<Payment>> GetPaymentAll();
        Task<NewPaymentDropDownViewModel> GetDropDown();
        Task<Payment> GetByIdWithTypePaymentAsync(int id);

    }

    
}
