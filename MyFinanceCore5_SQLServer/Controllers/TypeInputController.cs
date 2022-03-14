using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFinanceCore5_SQLServer.Models.Entity;
using MyFinanceCore5_SQLServer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Controllers
{
    public class TypeInputController : BaseController
    {
        private readonly ITypeInputsService _service;

        public TypeInputController(ITypeInputsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
           var data =  await _service.GetAllAsync(u => u.User);
            return View(data);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TypeInput obj)
        {
            if (ModelState.IsValid)
            {
                await _service.AddAsync(obj);
                return RedirectToAction(nameof(Index));
            }
            return View(obj);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { msg = "Id é nulo !" });
            }
            var obj = await _service.GetByIdAsync(id.Value, u => u.User);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { msg = "Não foi encontrado nenhum tipo de conta fixa" });
            }

            return View(obj);
        }

        //------------------------------Delete----------------------------------------------
        public async Task<IActionResult> Delete(int? id)
        {

            if (id == null)
            {
                RedirectToAction(nameof(Error), new { msg = "Id é nulo !" });
            }
            var obj = await _service.GetByIdAsync(id.Value);
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
                await _service.DeleteAsync(id);
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


        [HttpPost]
        public async Task<JsonResult> DeleteJson(int id) // confirmação do delete
        {
            try
            {
                await _service.DeleteAsync(id);
                return Json(true);
            }
            catch (Exception e)
            {

                return Json(new 
                {
                    msg = "Não pode ser Excluído - " + e.Message
                });
            }

        }


        //------------------------------Edit----------------------------------------------
        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
            {
                RedirectToAction(nameof(Error), new { msg = "Id é nulo !" });
            }
            var obj = await _service.GetByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { msg = "Não foi encontrado nenhum tipo de pagamento" });
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TypeInput obj)
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
                await _service.UpdateAsync(id, obj);
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

    }
}
