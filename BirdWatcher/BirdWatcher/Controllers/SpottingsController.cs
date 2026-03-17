using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BirdWatcher.Models;

namespace BirdWatcher.Controllers
{
    public class SpottingsController : Controller
    {
        private readonly BirdWatcherG1Context _context;

        public SpottingsController(BirdWatcherG1Context context)
        {
            _context = context;
        }

        // GET: Spottings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Spottings.ToListAsync());
        }

        // GET: Spottings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spotting = await _context.Spottings
                .FirstOrDefaultAsync(m => m.SpottingId == id);
            if (spotting == null)
            {
                return NotFound();
            }

            return View(spotting);
        }

        // GET: Spottings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Spottings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SpottingId,SpottingDescription,TimeSeen,ImageUrl")] Spotting spotting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(spotting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(spotting);
        }

        // GET: Spottings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spotting = await _context.Spottings.FindAsync(id);
            if (spotting == null)
            {
                return NotFound();
            }
            return View(spotting);
        }

        // POST: Spottings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SpottingId,SpottingDescription,TimeSeen,ImageUrl")] Spotting spotting)
        {
            if (id != spotting.SpottingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(spotting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpottingExists(spotting.SpottingId))
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
            return View(spotting);
        }

        // GET: Spottings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spotting = await _context.Spottings
                .FirstOrDefaultAsync(m => m.SpottingId == id);
            if (spotting == null)
            {
                return NotFound();
            }

            return View(spotting);
        }

        // POST: Spottings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var spotting = await _context.Spottings.FindAsync(id);
            if (spotting != null)
            {
                _context.Spottings.Remove(spotting);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpottingExists(int id)
        {
            return _context.Spottings.Any(e => e.SpottingId == id);
        }
    }
}
