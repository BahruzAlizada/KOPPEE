using KOPPEE.DAL;
using KOPPEE.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KOPPEE.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class BiosController : Controller
    {
        private readonly AppDbContext _db;

        public BiosController(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            List<Bio> bios = await _db.Bio.ToListAsync();
            return View(bios);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return NotFound();
            Bio dbbio = await _db.Bio.FirstOrDefaultAsync(x => x.Id == id);
            if (dbbio == null)
                return BadRequest();

            return View(dbbio);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id,Bio bio)
        {
            if (id == null)
                return NotFound();
            Bio dbbio = await _db.Bio.FirstOrDefaultAsync(x => x.Id == id);
            if (dbbio == null)
                return BadRequest();

            dbbio.HeaderLogoName = bio.HeaderLogoName;
            dbbio.FooterNumber = bio.FooterNumber;
            dbbio.FooterAddress = bio.FooterAddress;
            dbbio.FooterEmail = bio.FooterEmail;

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();
            Bio dbbio = await _db.Bio.FirstOrDefaultAsync(x => x.Id == id);
            if (dbbio == null)
                return BadRequest();

            return View(dbbio);
        }
    }
}
