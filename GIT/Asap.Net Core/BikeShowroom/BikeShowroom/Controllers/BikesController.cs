using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BikeShowroom.Data;
using BikeShowroom.Models;

namespace BikeShowroom.Controllers
{
    public class BikesController : Controller
    {
        private readonly BikeShowroomContext _Context;

        public BikesController(BikeShowroomContext context)
        {
            _Context = context;
        }

        // GET: Bikes
        public async Task<IActionResult> Index()
        {
            return View(await _Context.Bikes.ToListAsync());
        }

        // GET: Bikes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bikes = await _Context.Bikes
                .FirstOrDefaultAsync(m => m.BikeNums == id);
            if (bikes == null)
            {
                return NotFound();
            }

            return View(bikes);
        }

        // GET: Bikes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bikes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BikeNums,BikeNames,BikeModel,BikeVerison")] Bikes bikes)
        {
            if (ModelState.IsValid)
            {
                _Context.Add(bikes);
                await _Context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bikes);
        }

        // GET: Bikes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bikes = await _Context.Bikes.FindAsync(id);
            if (bikes == null)
            {
                return NotFound();
            }
            return View(bikes);
        }

        // POST: Bikes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BikeNums,BikeNames,BikeModel,BikeVerison")] Bikes bikes)
        {
            if (id != bikes.BikeNums)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _Context.Update(bikes);
                    await _Context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    //if (!BikesExists(bikes.BikeNums))
                    //{
                    //    throw;
                    //}
                    //else
                    //{
                    //    return NotFound();
                    //}
                }
                return RedirectToAction(nameof(Index));
            }
            return View(bikes);
        }

        // GET: Bikes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bikes = await _Context.Bikes
                .FirstOrDefaultAsync(m => m.BikeNums == id);
            if (bikes == null)
            {
                return NotFound();
            }

            return View(bikes);
        }

        // POST: Bikes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bikes = await _Context.Bikes.FindAsync(id);
            _Context.Bikes.Remove(bikes);
            await _Context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BikesExists(int id)
        {
            return _Context.Bikes.Any(e => e.BikeNums == id);
        }
    }
}
