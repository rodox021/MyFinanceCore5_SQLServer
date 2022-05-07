using MyFinanceCore5_SQLServer.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Models.ViewModels
{
    public class NewPaymentDropDownViewModel
    {
        public NewPaymentDropDownViewModel()
        {
            TypePayments = new List<TypePayment>();
        }

        public List<TypePayment> TypePayments { get; set; }
    }
}
