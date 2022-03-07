using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyFinanceCore5_SQLServer.Data;
using MyFinanceCore5_SQLServer.Models;
using MyFinanceCore5_SQLServer.Models.Entity;
using MyFinanceCore5_SQLServer.Models.ViewModels;
using MyFinanceCore5_SQLServer.Services.Interfaces;

namespace MyFinanceCore5_SQLServer.Controllers
{
    public class PictureIconsController : Controller
    {
       // private readonly AppDbContext _contextt;
        private readonly IPictureIconsService _pictureIconsService;

        public PictureIconsController(IPictureIconsService pictureIconsService)
        {
            //_context = context;
            _pictureIconsService = pictureIconsService;
        }

        // GET: PictureIcons--------------------------------------------------------------------
        public async Task<IActionResult> Index()
        {
            //return View(await _context.PictureIcons.ToListAsync());
            return View(await _pictureIconsService.GetAllAsync());
        }

        // GET: PictureIcons/Details/5--------------------------------------------------------------------
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { msg = "Id é nulo !" }); //return NotFound();
            }

            var pictureIcon = await _pictureIconsService.GetByIdAsync(id.Value);  // _context.PictureIcons .FirstOrDefaultAsync(m => m.Id == id);
            if (pictureIcon == null)
            {
                return RedirectToAction(nameof(Error), new { msg = "Id é nulo !" }); //return NotFound();
            }

            return View(pictureIcon);
        }

        // GET: PictureIcons/Create--------------------------------------------------------------------
        public IActionResult Create()
        {
            return View();
        }

        // POST: PictureIcons/Create--------------------------------------------------------------------

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,IconClass")] PictureIcon pictureIcon)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(pictureIcon);
                //await _context.SaveChangesAsync();
                await _pictureIconsService.AddAsync(pictureIcon);
                return RedirectToAction(nameof(Index));
            }
            return View(pictureIcon);
        }

        // GET: PictureIcons/Edit/5--------------------------------------------------------------------
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { msg = "Id é nulo !" });
            }

            var pictureIcon = await _pictureIconsService.GetByIdAsync(id.Value); //_context.PictureIcons.FindAsync(id);
            if (pictureIcon == null)
            {
                return RedirectToAction(nameof(Error), new
                {
                    msg = "Id de usuário não encontrato ou já foi deletado"
                });
            }
            return View(pictureIcon);
        }

        // POST: PictureIcons/Edit/5--------------------------------------------------------------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,IconClass")] PictureIcon pictureIcon)
        {
            if (!ModelState.IsValid)
            {
                return View(pictureIcon);
            }
            if (id != pictureIcon.Id)
            {
                return RedirectToAction(nameof(Error), new
                {
                    msg = "Id de usuário não correspondente"
                }); ;
            }


            try
            {
                //_context.Update(pictureIcon);
                //await _context.SaveChangesAsync();

                await _pictureIconsService.UpdateAsync(id, pictureIcon);
                return RedirectToAction(nameof(Index));
            }
            
            catch (DbUpdateConcurrencyException e)
            {

                return RedirectToAction(nameof(Error), new
                {
                    msg =  e.Message
                }); ;

            }
            catch (Exception e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }



        }

        // GET: PictureIcons/Delete/5--------------------------------------------------------------------
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new
                {
                    msg = "Id é nulo !"
                });

            }

            var pictureIcon = await _pictureIconsService.GetByIdAsync(id.Value); //_context.PictureIcons.FirstOrDefaultAsync(m => m.Id == id);
            if (pictureIcon == null)
            {
                return RedirectToAction(nameof(Error), new
                {
                    msg = "Id de usuário não encontrato ou já foi deletado"
                }); ;
            }

            return View(pictureIcon);
        }

        // POST: PictureIcons/Delete/5--------------------------------------------------------------------
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {

                //var pictureIcon = await _context.PictureIcons.FindAsync(id);
                //_context.PictureIcons.Remove(pictureIcon);
                //await _context.SaveChangesAsync();
                await _pictureIconsService.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegritException e)
            {
                return RedirectToAction(nameof(Error), new
                {
                    msg = "Esse tipo de pagamento não poder Excluído,  verifique se contém compras associados ao tip de pagamento " + e.Message
                });
            }
            catch (Exception e)
            {

                return RedirectToAction(nameof(Error), new
                {
                    msg = "Não pode ser Excluído - " + e.Message
                });
            }
        }
        //--------------------------------------------------------------------

        public IActionResult Error(string msg)
        {
            var viewModel = new ErrorViewModel
            {
                Message = msg,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
        //--------------------------------------------------------------------
        //private bool PictureIconExists(int id)
        //{
        //    return _context.PictureIcons.Any(e => e.Id == id);
        //}
    }
}
