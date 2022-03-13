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
    public class TypePaymentController : BaseController
    {
        private readonly ITypePaymentsService _typePayment;
        private readonly IPictureIconsService _picture;

        public TypePaymentController(ITypePaymentsService typePayment, IPictureIconsService picture)
        {
            _typePayment = typePayment;
            _picture = picture;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _typePayment.GetAllWthPictureAsync();

            return View(data);
        }
        //---------------------------------------------------------------------------------------------------------
        public async Task<IActionResult> Create()
        {
            
            var icons = await _picture.GetAllAsync();
            ViewBag.icons = new SelectList(icons,"Id","Name");

            //ViewData["msg"] = "Pagina para salvar!";
            return View();
            //return PartialView(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TypePayment obj)
        {
            if (!ModelState.IsValid)
            {
                var icons = await _picture.GetAllAsync();
                ViewBag.icons = new SelectList(icons, "Id", "Name");
                return View(obj);
            }

            await _typePayment.AddAsync(obj);
            return RedirectToAction(nameof(Index));
        }
        //---------------------------------------------------------------------------------------------------------
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null )
            {
                return RedirectToAction(nameof(Error), new { msg = "Id é nulo !" });
            }
            var data = await _typePayment.GetByIdWithPictureAsync(id.Value);
            if (data == null)
            {
                return RedirectToAction(nameof(Error), new { msg = "Não foi encontrado nenhum tipo de pagamento" });
            }


           return View(data);
            //return PartialView("Details", data);
            //return PartialView(data);
        }
        //---------------------------------------------------------------------------------------------------------
        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { msg = "Id é nulo !" });
            }

            var obj = await _typePayment.GetByIdWithPictureAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { msg = "Não foi encontrado nenhum tipo de pagamento" });
            }
            var icons = await _picture.GetAllAsync();
            ViewBag.icons = new SelectList(icons, "Id", "Name");

            var ViewModel = new CreateTypePaymenteViewModel()
            {
                FlagCard = obj.FlagCard,
                PictureIconId = obj.PictureIconId,
                UserId = obj.UserID
            };
            //return View(data);
            //return PartialView("Details", data);
            return View(ViewModel);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TypePayment obj)
        {
            if (!ModelState.IsValid)
            {
                var icons = await _picture.GetAllAsync();
                ViewBag.icons = new SelectList(icons, "Id", "Name");
                return View();
               
            }
            if (id != obj.Id)
            {
                return RedirectToAction(nameof(Error), new
                {
                    msg = "Id de usuário não correspondente"
                });
            }

            try
            {
                await _typePayment.UpdateAsync(id, obj);
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
        //---------------------------------------------------------------------------------------------------------

        public async Task<IActionResult> Delete(int? id)
        {

            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { msg = "Id é nulo !" });
            }
            var data = await _typePayment.GetByIdWithPictureAsync(id.Value);
            if (data == null)
            {
                return RedirectToAction(nameof(Error), new { msg = "Não foi encontrado nenhum tipo de pagamento" });
            }


            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {

            try
            {
                await _typePayment.DeleteAsync(id);
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
    }
}
