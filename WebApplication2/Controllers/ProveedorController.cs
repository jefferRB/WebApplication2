using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProveedorController : Controller
    {
        private readonly AppDbContext _context;

        public ProveedorController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Principal()
        {
            return View();
        }
        public async Task<IActionResult> Index()
        {
            var provedores = await _context.Provedores.ToListAsync();
            return View(provedores);
        }
        // GET: SuppliersController

        // GET: SuppliersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SuppliersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuppliersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Direccion,Articulo")] Proveedor proveedor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(proveedor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(proveedor);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var proveedor = await _context.Provedores.FindAsync(id);
            if (proveedor == null)
            {
                return NotFound();
            }
            return View(proveedor);
        }



        // GET: SuppliersController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var proveedor = await _context.Provedores.FindAsync(id);
            if (proveedor == null)
            {
                return NotFound();
            }
            return View(proveedor);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id, Proveedor proveedor)
        {
            if(id != proveedor.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Remove(proveedor);
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProveedorExists(proveedor.Id))
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
            return View(proveedor);
        }
        private bool ProveedorExists(int id)
        {
            return _context.Provedores.Any(e => e.Id == id);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, Proveedor proveedor)

        {
            if (id != proveedor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(proveedor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                { 
                    if (!ProveedorExists(proveedor.Id))
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
            return View(proveedor);
        }
    }
}
