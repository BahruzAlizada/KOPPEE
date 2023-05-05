using KOPPEE.DAL;
using KOPPEE.Models;
using KOPPEE.ViewsModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace KOPPEE.Controllers
{
	public class HomeController : Controller
	{
		private readonly AppDbContext _db;

        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
		{
			Offer offer = await _db.Offer.FirstOrDefaultAsync();
			return View(offer);
		}

		public async Task<IActionResult> Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]

		public async Task<IActionResult> Create(Reservation reservation)
		{
			if (reservation.Date <= DateTime.Today)
			{
				ModelState.AddModelError("Date","This is not right Date !");
				return View();
			}

			if (reservation.PhoneNumber.Length > 10)
			{
				ModelState.AddModelError("PhoneNumber", "ForExample - 0999999999");
				return View();
			}


			await _db.Reservationss.AddAsync(reservation);
			await _db.SaveChangesAsync();
			return RedirectToAction("Index");
		}
		
		public IActionResult Error()
		{
			return View();
		}
	}
}
