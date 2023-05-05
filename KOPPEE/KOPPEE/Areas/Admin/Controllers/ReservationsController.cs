using KOPPEE.DAL;
using KOPPEE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KOPPEE.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReservationsController : Controller
    {
        private readonly AppDbContext _db;

        public ReservationsController(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            List<Reservation> reservations = await _db.Reservationss.ToListAsync();
            return View(reservations);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();
            Reservation dbreservation = await _db.Reservationss.FirstOrDefaultAsync(x=>x.Id==id);
            if (dbreservation == null)
                return BadRequest();

            return View(dbreservation);
        }

        public async Task<IActionResult> Activity(int? id)
        {
            if (id == null)
                return NotFound();
            Reservation dbreservation = await _db.Reservationss.FirstOrDefaultAsync(x => x.Id == id);
            if (dbreservation == null)
                return BadRequest();

            if (dbreservation.IsDeactive)
                dbreservation.IsDeactive = false;
            else
                dbreservation.IsDeactive = true;

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
