using AthleteSystem.Data;
using AthleteSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AthleteSystem.Controllers
{
    public class AthleteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AthleteController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var athletes = await _context.Athletes.ToListAsync();
            return View(athletes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Athlete athlete)
        {
            if (ModelState.IsValid)
            {
                _context.Add(athlete);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(athlete);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var athlete = await _context.Athletes.FindAsync(id);
            if (athlete == null) return NotFound();
            return View(athlete);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Athlete athlete)
        {
            if (id != athlete.Id) return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(athlete);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(athlete);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var athlete = await _context.Athletes.FindAsync(id);
            if (athlete == null) return NotFound();
            return View(athlete);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var athlete = await _context.Athletes.FindAsync(id);
            if (athlete != null)
            {
                _context.Athletes.Remove(athlete);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
