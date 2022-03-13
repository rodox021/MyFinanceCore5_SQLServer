using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFinanceCore5_SQLServer.Models.Entity;
using MyFinanceCore5_SQLServer.Models.ViewModels;
using MyFinanceCore5_SQLServer.Services.Exception;
using MyFinanceCore5_SQLServer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            var data = await _typeFixedBillsService.GetAllAsync(u => u.User);

            return View(data);
        } 
     





        //------------------------------Details----------------------------------------------
        public async Task<IActionResult> Details(int?id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { msg = "Id é nulo !" });
            }
            var obj = await _typeFixedBillsService.GetByIdAsync(id.Value, u => u.User);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { msg = "Não foi encontrado nenhum tipo de conta fixa" });
            }

            return View(obj);
        }







        //------------------------------Create----------------------------------------------
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TypeFixedBill obj)
        {
            if (ModelState.IsValid)
            {
                await _typeFixedBillsService.AddAsync(obj);
                return RedirectToAction(nameof(Index));
            }
            return View(obj);
        }







        //------------------------------Edit----------------------------------------------
        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
            {
                RedirectToAction(nameof(Error), new { msg = "Id é nulo !" });
            }
            var obj = await _typeFixedBillsService.GetByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { msg = "Não foi encontrado nenhum tipo de pagamento" });
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TypeFixedBill obj)
        {
            if (!ModelState.IsValid)
            {
                return View(obj);
            }
            if (id != obj.Id)
            {
                return RedirectToAction(nameof(Error), new
                {
                    msg = "Id de usuário não correspondente"
                }); ;
            }

            try
            {
                await _typeFixedBillsService.UpdateAsync(id, obj);
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException e)
            {

                return RedirectToAction(nameof(Error), new
                {
                    msg = e.Message
                }); ;
            }
            catch (Exception e)
            {

                return RedirectToAction(nameof(Error), new
                {
                    msg = e.Message
                }); ;
            }
        }





        //------------------------------Delete----------------------------------------------
        public async Task<IActionResult> Delete(int? id)
        {

            if (id == null)
            {
                RedirectToAction(nameof(Error), new { msg = "Id é nulo !" });
            }
            var obj = await _typeFixedBillsService.GetByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { msg = "Não foi encontrado nenhum tipo de pagamento" });
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id) // confirmação do delete
        {
            try
            {
                await _typeFixedBillsService.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {

                return RedirectToAction(nameof(Error), new
                {
                    msg = "Não pode ser Excluído - " + e.Message
                });
            }
            
        }




        //------------------------------Delete----------------------------------------------
        
    }
}
