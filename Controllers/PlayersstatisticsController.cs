using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DotNetCoreSqlDb;

namespace DotNetCoreSqlDb.Controllers
{
    public class PlayersstatisticsController : Controller
    {
        private readonly FootballContext _context;

        public PlayersstatisticsController(FootballContext context)
        {
            _context = context;
        }

        // GET: Playersstatistics
        public async Task<IActionResult> Index()
        {
            return View(await _context.Playersstatistics.ToListAsync());
        }

        // GET: Playersstatistics/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playersstatistics = await _context.Playersstatistics
                .FirstOrDefaultAsync(m => m.Id == id);
            if (playersstatistics == null)
            {
                return NotFound();
            }

            return View(playersstatistics);
        }

        // GET: Playersstatistics/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Playersstatistics/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Rank,Player,Team,Position,Age,Gamesplayed,Passescompleted,Fantasypoints,Pprscoring,Posrank,Week1,Week2,Week3,Week4,Week5,Week6,Week7,Week8,Week9,Week10,Week11,Week12,Week13,Week14,Week15,Week16,Week17")] Playersstatistics playersstatistics)
        {
            if (ModelState.IsValid)
            {
                _context.Add(playersstatistics);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(playersstatistics);
        }

        // GET: Playersstatistics/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playersstatistics = await _context.Playersstatistics.FindAsync(id);
            if (playersstatistics == null)
            {
                return NotFound();
            }
            return View(playersstatistics);
        }

        // POST: Playersstatistics/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Rank,Player,Team,Position,Age,Gamesplayed,Passescompleted,Fantasypoints,Pprscoring,Posrank,Week1,Week2,Week3,Week4,Week5,Week6,Week7,Week8,Week9,Week10,Week11,Week12,Week13,Week14,Week15,Week16,Week17")] Playersstatistics playersstatistics)
        {
            if (id != playersstatistics.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(playersstatistics);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayersstatisticsExists(playersstatistics.Id))
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
            return View(playersstatistics);
        }

        // GET: Playersstatistics/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var playersstatistics = await _context.Playersstatistics
                .FirstOrDefaultAsync(m => m.Id == id);
            if (playersstatistics == null)
            {
                return NotFound();
            }

            return View(playersstatistics);
        }

        // POST: Playersstatistics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var playersstatistics = await _context.Playersstatistics.FindAsync(id);
            _context.Playersstatistics.Remove(playersstatistics);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlayersstatisticsExists(int id)
        {
            return _context.Playersstatistics.Any(e => e.Id == id);
        }
    }
}
