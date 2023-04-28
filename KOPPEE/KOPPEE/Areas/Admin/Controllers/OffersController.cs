using KOPPEE.DAL;
using KOPPEE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KOPPEE.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class OffersController : Controller
	{
		private readonly AppDbContext _db;

        public OffersController(AppDbContext db)
        {
			_db = db;
        }
        public async Task<IActionResult> Index()
		{
			List<Offer> offer = await _db.Offer.ToListAsync();
			return View(offer);
		}

		public async Task<IActionResult> Update(int? id)
		{
			if (id == null)
				return NotFound();
			Offer dboffer = await _db.Offer.FirstOrDefaultAsync(x => x.Id == id);
			if (dboffer == null)
				return BadRequest();

			return View(dboffer);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]

		public async Task<IActionResult> Update(int? id,Offer offer)
		{
			if (id == null)
				return NotFound();
			Offer dboffer = await _db.Offer.FirstOrDefaultAsync(x => x.Id == id);
			if (dboffer == null)
				return BadRequest();

			dboffer.Title = offer.Title;
			dboffer.SubTitle = offer.SubTitle;
			dboffer.Description = offer.Description;

			await _db.SaveChangesAsync();
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> Detail(int? id)
		{
			if (id == null)
				return NotFound();
			Offer dboffer = await _db.Offer.FirstOrDefaultAsync(x=>x.Id==id);
			if (dboffer == null)
				return BadRequest();

			return View(dboffer);
		}
	}
}
