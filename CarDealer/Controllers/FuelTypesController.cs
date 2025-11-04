using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarDealer.Data;
using CarDealer.Models;

namespace CarDealer.Controllers
{
    public class FuelTypesController : Controller
    {
        private readonly CarDealerContext _context;

        public FuelTypesController(CarDealerContext context)
        {
            _context = context;
        }

        // GET: FuelTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.FuelType.ToListAsync());
        }

        // GET: FuelTypes/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var fuelType = await _context.FuelType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fuelType == null)
            {
                return NotFound();
            }

            return View(fuelType);
        }

        // GET: FuelTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FuelTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] FuelType fuelType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fuelType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fuelType);
        }

        // GET: FuelTypes/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var fuelType = await _context.FuelType.FindAsync(id);
            if (fuelType == null)
            {
                return NotFound();
            }
            return View(fuelType);
        }

        // POST: FuelTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("Id,Name")] FuelType fuelType)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fuelType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FuelTypeExists(fuelType.Id))
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
            return View(fuelType);
        }

        // GET: FuelTypes/Delete/5
        public async Task<IActionResult> Delete(int id, bool? saveChangesError = false)
        {
            var fuelType = await _context.FuelType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fuelType == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Problem might be caused because this FuelType is currently in use, if that not the case " +
                    "see your system administrator.";
            }

            return View(fuelType);
        }

        // POST: FuelTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var fuelType = await _context.FuelType.FindAsync(id);
                if (fuelType != null)
                {
                    _context.FuelType.Remove(fuelType);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.)
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
        }

        private bool FuelTypeExists(int id)
        {
            return _context.FuelType.Any(e => e.Id == id);
        }
    }
}
