// Controllers/ComputerPartsController.cs
using Microsoft.AspNetCore.Mvc;
using ComputerPartsStore.Data;
using ComputerPartsStore.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ComputerPartsStore.Controllers
{
    public class ComputerPartsController : Controller
    {
        private readonly AppDbContext _context;

        public ComputerPartsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ComputerParts
        public async Task<IActionResult> Index()
        {
            return View(await _context.ComputerParts.ToListAsync());
        }

        // GET: ComputerParts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ComputerParts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ComputerPart computerPart)
        {
            if (ModelState.IsValid)
            {
                _context.Add(computerPart);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(computerPart);
        }

        // GET: ComputerParts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var computerPart = await _context.ComputerParts.FindAsync(id);
            if (computerPart == null) return NotFound();

            return View(computerPart);
        }

        // POST: ComputerParts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ComputerPart computerPart)
        {
            if (id != computerPart.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(computerPart);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.ComputerParts.Any(e => e.Id == computerPart.Id))
                        return NotFound();
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(computerPart);
        }

        // GET: ComputerParts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var computerPart = await _context.ComputerParts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (computerPart == null) return NotFound();

            return View(computerPart);
        }

        // POST: ComputerParts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var computerPart = await _context.ComputerParts.FindAsync(id);
            _context.ComputerParts.Remove(computerPart);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}