using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using prjCapeloWeb.Models;

namespace prjCapeloWeb.Controllers
{
    [Authorize]
    public class GrupoMuscularController : Controller
    {
        private readonly Context _context;

        public GrupoMuscularController(Context context)
        {
            _context = context;
        }

        // GET: GrupoMuscular
        public async Task<IActionResult> Index()
        {
            return View(await _context.GruposMusculares.ToListAsync());
        }

        // GET: GrupoMuscular/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grupoMuscular = await _context.GruposMusculares
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grupoMuscular == null)
            {
                return NotFound();
            }

            return View(grupoMuscular);
        }

        // GET: GrupoMuscular/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GrupoMuscular/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Id,CriadoEm")] GrupoMuscular grupoMuscular)
        {
            if (ModelState.IsValid)
            {
                _context.Add(grupoMuscular);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(grupoMuscular);
        }

        // GET: GrupoMuscular/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grupoMuscular = await _context.GruposMusculares.FindAsync(id);
            if (grupoMuscular == null)
            {
                return NotFound();
            }
            return View(grupoMuscular);
        }

        // POST: GrupoMuscular/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nome,Id,CriadoEm")] GrupoMuscular grupoMuscular)
        {
            if (id != grupoMuscular.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(grupoMuscular);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GrupoMuscularExists(grupoMuscular.Id))
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
            return View(grupoMuscular);
        }

        // GET: GrupoMuscular/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grupoMuscular = await _context.GruposMusculares.FindAsync(id);
            _context.GruposMusculares.Remove(grupoMuscular);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // POST: GrupoMuscular/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var grupoMuscular = await _context.GruposMusculares.FindAsync(id);
            _context.GruposMusculares.Remove(grupoMuscular);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GrupoMuscularExists(int id)
        {
            return _context.GruposMusculares.Any(e => e.Id == id);
        }
    }
}
