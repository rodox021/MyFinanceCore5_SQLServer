using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyFinanceCore5_SQLServer.Data;
using MyFinanceCore5_SQLServer.Models.Entity;
using MyFinanceCore5_SQLServer.Services.Interfaces;

namespace MyFinanceCore5_SQLServer.Controllers
{
    public class PictureIconsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IPictureIconsService _pictureIconsService;

        public PictureIconsController(AppDbContext context, IPictureIconsService pictureIconsService)
        {
            _context = context;
            _pictureIconsService = pictureIconsService;
        }

        // GET: PictureIcons
        public async Task<IActionResult> Index()
        {
            //return View(await _context.PictureIcons.ToListAsync());
            return View(await _pictureIconsService.GetAllAsync());
        }

        // GET: PictureIcons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pictureIcon = await _pictureIconsService.GetByIdAsync(id.Value);  // _context.PictureIcons .FirstOrDefaultAsync(m => m.Id == id);
            if (pictureIcon == null)
            {
                return NotFound();
            }

            return View(pictureIcon);
        }

        // GET: PictureIcons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PictureIcons/Create
       
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

        // GET: PictureIcons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return View("NotFound");
            }

            var pictureIcon = await _pictureIconsService.GetByIdAsync(id.Value); //_context.PictureIcons.FindAsync(id);
            if (pictureIcon == null)
            {
                return View("NotFound");
            }
            return View(pictureIcon);
        }

        // POST: PictureIcons/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,IconClass")] PictureIcon pictureIcon)
        {
            if (id != pictureIcon.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //_context.Update(pictureIcon);
                    //await _context.SaveChangesAsync();
                    await _pictureIconsService.UpdateAsync(id, pictureIcon);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PictureIconExists(pictureIcon.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pictureIcon);
        }

        // GET: PictureIcons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pictureIcon = await _pictureIconsService.GetByIdAsync(id.Value); //_context.PictureIcons.FirstOrDefaultAsync(m => m.Id == id);
            if (pictureIcon == null)
            {
                return NotFound();
            }

            return View(pictureIcon);
        }

        // POST: PictureIcons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pictureIcon = await _context.PictureIcons.FindAsync(id);
            _context.PictureIcons.Remove(pictureIcon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PictureIconExists(int id)
        {
            return _context.PictureIcons.Any(e => e.Id == id);
        }
    }
}
