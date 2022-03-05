using Microsoft.AspNetCore.Mvc;
using MyFinanceCore5_SQLServer.Models.Entity;
using MyFinanceCore5_SQLServer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Controllers
{
    public class TypeFixedBillsController : BaseController
    {
        private readonly ITypeFixedBillsService _typeFixedBillsService;

        public TypeFixedBillsController(ITypeFixedBillsService typeFixedBillsService)
        {
            _typeFixedBillsService = typeFixedBillsService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _typeFixedBillsService.GetAllAsync();

            return View(data);
        } 
     





        //------------------------------Details----------------------------------------------
        public IActionResult Details(int?id)
        {
            return View();
        }







        //------------------------------Create----------------------------------------------
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TypeFixedBill obj)
        {
            return View();
        }







        //------------------------------Edit----------------------------------------------
        public IActionResult Edit(int? id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, TypeFixedBill obj)
        {
            return View();
        }





        //------------------------------Delete----------------------------------------------
        public IActionResult Delete(int? id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id) // confirmação do delete
        {
            return View();
        }
    }
}
