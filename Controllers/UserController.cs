using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DotNetCoreSqlDb.Models;
using Microsoft.Data.SqlClient;
using System.Text.Encodings.Web;

namespace DotNetCoreSqlDb.Controllers
{
    public class UserController : Controller
    {
        private readonly FootballContext _context;

        public UserController(FootballContext context)
        {
            _context = context;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserType.ToListAsync());
        }

        // GET: User/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.UserType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: User/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,Password,Member1,Member2,Member3,Member4,Member5,Member6,Member7,Member8,Member9,Member10")] UserType user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: User/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.UserType.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Password")] UserType user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
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
            return View(user);
        }

        // GET: User/Create
        public IActionResult GetPlayerScore()
        {
            return NotFound();
        }

        // POST: User/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetPlayerScore(int? id, int? week)
        {
            using (var newcontext = new FootballContext())
            {
                if (id == null)
                {
                    return NotFound();
                }
                var user = await _context.UserType.FindAsync(id);
                var sqlReturn = newcontext.Database.ExecuteSqlRaw((string.Format(@"SELECT SUM(CAST(p.Week{0} AS int)) AS Total 
                    FROM Playersstatistics p 
                    INNER JOIN UserType u ON(u.Member1 = p.Player OR u.Member2 = p.Player OR u.Member3 = p.Player OR u.Member4 = p.Player OR u.Member5 = p.Player OR u.Member6 = p.Player OR u.Member7 = p.Player OR u.Member8 = p.Player OR u.Member9 = p.Player OR u.Member10 = p.Player) AND u.ID = {1}", week, id)));
                //.FromSqlRaw(string.Format(@"SELECT SUM(CAST(p.Week{0} AS int)) AS Total 
                //FROM Playersstatistics p 
                //INNER JOIN UserType u ON(u.Member1 = p.Player OR u.Member2 = p.Player OR u.Member3 = p.Player OR u.Member4 = p.Player OR u.Member5 = p.Player OR u.Member6 = p.Player OR u.Member7 = p.Player OR u.Member8 = p.Player OR u.Member9 = p.Player OR u.Member10 = p.Player) AND u.ID = {1}", week, id))
                ViewData["value"] = sqlReturn;
                return View();
            }  
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.UserType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.UserType.FindAsync(id);
            _context.UserType.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.UserType.Any(e => e.Id == id);
        }
    }
}
