using KOPPEE.DAL;
using KOPPEE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KOPPEE.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class FeedbacksController : Controller
	{
		private readonly AppDbContext _db;

        public FeedbacksController(AppDbContext db)
        {
			_db = db;
        }

        public async Task<IActionResult> Index()
		{
			List<FeedBack> feedBacks = await _db.FeedBacks.ToListAsync();
			return View(feedBacks);
		}

		public async Task<IActionResult> Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]

		public async Task<IActionResult> Create(FeedBack feedBack)
		{
			if (feedBack.FullName == null)
			{
				ModelState.AddModelError("FullName", "Name can not be null");
				return View();
			}

			if (feedBack.Description == null)
			{
				ModelState.AddModelError("Description", "Description can not be null");
				return View();
			}

			await _db.FeedBacks.AddAsync(feedBack);
			await _db.SaveChangesAsync();
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> Update(int? id)
		{
			if (id == null)
				return NotFound();
			FeedBack dbfeedbacks = await _db.FeedBacks.FirstOrDefaultAsync(x=>x.Id==id);
			if (dbfeedbacks == null)
				return BadRequest();

			return View(dbfeedbacks);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]

		public async Task<IActionResult> Update(int? id, FeedBack feedBack)
		{
			if (id == null)
				return NotFound();
			FeedBack dbfeedbacks = await _db.FeedBacks.FirstOrDefaultAsync(x => x.Id == id);
			if (dbfeedbacks == null)
				return BadRequest();

			if (feedBack.FullName == null)
			{
				ModelState.AddModelError("FullName", "Name can not be null");
				return View();
			}

			if (feedBack.Description == null)
			{
				ModelState.AddModelError("Description", "Description can not be null");
				return View();
			}

			dbfeedbacks.FullName = feedBack.FullName;
			dbfeedbacks.Role = feedBack.Role;
			dbfeedbacks.Description = feedBack.Description;

			await _db.SaveChangesAsync();
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> Detail(int? id)
		{
			if (id == null)
				return NotFound();
			FeedBack dbfeedbacks = await _db.FeedBacks.FirstOrDefaultAsync(x => x.Id == id);
			if (dbfeedbacks == null)
				return BadRequest();

			return View(dbfeedbacks);
		}

		public async Task<IActionResult> Activity(int? id)
		{
			if (id == null)
				return NotFound();
			FeedBack dbfeedbacks = await _db.FeedBacks.FirstOrDefaultAsync(x => x.Id == id);
			if (dbfeedbacks == null)
				return BadRequest();

			if (dbfeedbacks.IsDeactive)
				dbfeedbacks.IsDeactive = false;
			else
				dbfeedbacks.IsDeactive = true;

			await _db.SaveChangesAsync();
			return RedirectToAction("Index");
		}
	}
}
