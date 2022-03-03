using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyFinanceCore5_SQLServer.Data;
using MyFinanceCore5_SQLServer.Models.Entity;

namespace MyFinanceCore5_SQLServer.Controllers
{
    public class PictureIconsController : Controller
    {
        private readonly AppDbContext _context;

        public PictureIconsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: PictureIcons
        public async Task<IActionResult> Index()
        {
            return View(await _context.PictureIcons.ToListAsync());
        }

        // GET: PictureIcons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pictureIcon = await _context.PictureIcons
                .FirstOrDefaultAsync(m => m.Id == id);
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
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,IconClass")] PictureIcon pictureIcon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pictureIcon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pictureIcon);
        }

        // GET: PictureIcons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pictureIcon = await _context.PictureIcons.FindAsync(id);
            if (pictureIcon == null)
            {
                return NotFound();
            }
            return View(pictureIcon);
        }

        // POST: PictureIcons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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
                    _context.Update(pictureIcon);
                    await _context.SaveChangesAsync();
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

            var pictureIcon = await _context.PictureIcons
                .FirstOrDefaultAsync(m => m.Id == id);
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
