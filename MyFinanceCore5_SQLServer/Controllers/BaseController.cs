using Microsoft.AspNetCore.Mvc;
using MyFinanceCore5_SQLServer.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Controllers
{
    public abstract class BaseController : Controller
    {
        public IActionResult Error(string msg)
        {
            var viewModel = new ErrorViewModel
            {
                Message = msg,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}
