using Microsoft.AspNetCore.Mvc;
using MyFinanceCore5_SQLServer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Controllers
{
    public class ShopController : BaseController
    {

        private readonly IShopsService _service;



        public ShopController(IShopsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetShopAll();
            return View(data);
        }
        public async Task<IActionResult> IndexJson()
        {
            var data = await _service.GetShopAll();



            return new JsonResult(data);
        }
    }
}
