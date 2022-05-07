using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyFinanceCore5_SQLServer.Models.Entity;
using MyFinanceCore5_SQLServer.Models.ViewModels;
using MyFinanceCore5_SQLServer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinanceCore5_SQLServer.Controllers
{
    public class PaymentController : BaseController
    {

        private readonly IPaymentsService _service;
        


        public PaymentController(IPaymentsService service)
        {
            _service = service;
        }
        // payment/ -----------------------------------------------------------------------
        public async Task<IActionResult> Index()
        {

            var data = await _service.GetPaymentAll();
            return View(data);
        }


        // payment/Create -----------------------------------------------------------------------
        public async Task<IActionResult> Create()
        {
            var data = await _service.GetDropDown();
            ViewBag.TypePayments = new SelectList(data.TypePayments, "Id", "FlagCard");

            return View();
        }
        // payment/Create -----------------------------------------------------------------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Payment obj)
        {
            if (!ModelState.IsValid)
            {
                var data = await _service.GetDropDown();
                ViewBag.TypePayments = new SelectList(data.TypePayments, "Id", "FlagCard");
                return View(obj);
            }

            await _service.AddAsync(obj);
            return RedirectToAction(nameof(Index));
        }

        // payment/Details/1 -----------------------------------------------------------------------
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { msg = "Id é nulo !" });
            }
            var data = await _service.GetByIdWithTypePaymentAsync(id.Value);
            if (data == null)
            {
                return RedirectToAction(nameof(Error), new { msg = "Não foi encontrado nenhum método de pagamento" });
            }


            return View(data);
        }

        // payment/Edit/1 -----------------------------------------------------------------------
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { msg = "Id é nulo !" });
            }

            var obj = await _service.GetByIdWithTypePaymentAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { msg = "Não foi encontrado nenhum método de pagamento" });
            }

            var data = await _service.GetDropDown();
            ViewBag.TypePayments = new SelectList(data.TypePayments, "Id", "FlagCard");

            var viewModel = new CreatePaymentViewModel()
            {
                Name = obj.Name,
                TypepaymentId = obj.TypePaymentId,
                UserId = obj.UserId
            };

            return View(viewModel);
        }


        // payment/Edit/1 -----------------------------------------------------------------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Payment obj)
        {


            if (!ModelState.IsValid)
            {
                var data = await _service.GetDropDown();
                ViewBag.TypePayments = new SelectList(data.TypePayments, "Id", "FlagCard");
                return View();
            }

           
            if (id != obj.Id)
            {
                return RedirectToAction(nameof(Error), new { msg = "Id não correspondente" });
            }

            try
            {
                await _service.UpdateAsync(id, obj);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {

                return RedirectToAction(nameof(Error), new
                {
                    msg = e.Message
                });
            }

           
        }

        // payment/Delete/1 -----------------------------------------------------------------------
        public async Task<IActionResult> Delete(int? id)
        {
            return View();
        }


        // payment/Delete/1 -----------------------------------------------------------------------
        [HttpPost]
        public async Task<JsonResult> Delete(int id)
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
    }
}
