using Microsoft.AspNetCore.Mvc;
using MyFinanceCore5_SQLServer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Controllers
{
    public class TypePaymentController : BaseController
    {
        private readonly ITypePaymentsService _typePayment;

        public TypePaymentController(ITypePaymentsService typePayment)
        {
            _typePayment = typePayment;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _typePayment.GetAllAsync();
           
            return View(data);
        }
    }
}
