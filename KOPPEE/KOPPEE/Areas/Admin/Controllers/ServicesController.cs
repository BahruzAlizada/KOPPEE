using KOPPEE.DAL;
using KOPPEE.Helper;
using KOPPEE.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KOPPEE.Areas.Admin.Controllers
{
	[Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ServicesController : Controller
	{
		private readonly AppDbContext _db;
		private readonly IWebHostEnvironment _env;

		public ServicesController(AppDbContext db,IWebHostEnvironment env)
		{
			_env = env;
			_db = db;
		}

		public async Task<IActionResult> Index()
		{
			List<Service> services = await _db.Services.ToListAsync();
			return View(services);
		}

		public async Task<IActionResult> Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]

		public async Task<IActionResult> Create(Service service)
		{
			bool isExist = await _db.Services.AnyAsync(x=>x.Name == service.Name);
			if(isExist)
			{
				ModelState.AddModelError("Name", "This Name already is exist");
				return View();
			}

			#region Photo
			if (service.Photo == null)
			{
				ModelState.AddModelError("Photo", "Photo can not be null");
				return View();
			}

			if (!service.Photo.IsImage())
			{
				ModelState.AddModelError("Photo", "Just select image type");
				return View();
			}

			if (service.Photo.IsOlder216Kb())
			{
				ModelState.AddModelError("Photo", "MAx 256Kb");
				return View();
			}

			string folder = Path.Combine(_env.WebRootPath, "img");
			service.Image = await service.Photo.SaveFileAsync(folder);
			#endregion

			await _db.Services.AddAsync(service);
			await _db.SaveChangesAsync();
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> Update(int? id)
		{
			if (id == null)
				return NotFound();
			Service dbservice = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
			if (dbservice == null)
				return BadRequest();

			return View(dbservice);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]

		public async Task<IActionResult> Update(int? id,Service service)
		{
			if (id == null)
				return NotFound();
			Service dbservice = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
			if (dbservice == null)
				return BadRequest();

			bool isExist = await _db.Services.AnyAsync(x=>x.Name==service.Name &&  x.Id!=id);
			if (isExist)
			{
				ModelState.AddModelError("Name", "This Name already is exist");
				return View();
			}

			#region Photo
			if(service.Photo != null)
			{
				if (!service.Photo.IsImage())
				{
					ModelState.AddModelError("Photo", "Just select image type");
					return View();
				}

				if(service.Photo.IsOlder216Kb())
				{
					ModelState.AddModelError("Photo", "Max 256Kb");
					return View();
				}

				string folder = Path.Combine(_env.WebRootPath, "img");
				service.Image = await service.Photo.SaveFileAsync(folder);
				string path = Path.Combine(_env.WebRootPath, folder, dbservice.Image);
				if (System.IO.File.Exists(path))
					System.IO.File.Delete(path);

				dbservice.Image = service.Image;
			}
			#endregion

			dbservice.Name = service.Name;
			dbservice.Description = service.Description;

			await _db.SaveChangesAsync();
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> Detail(int? id)
		{
			if (id == null)
				return NotFound();
			Service dbservice = await _db.Services.FirstOrDefaultAsync(x=>x.Id==id);
			if (dbservice == null)
				return BadRequest();

			return View(dbservice);
		}

		public async Task<IActionResult> Activity(int? id)
		{
			if (id == null)
				return NotFound();
			Service dbservice = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
			if (dbservice == null)
				return BadRequest();

			if (dbservice.IsDeactive)
				dbservice.IsDeactive = false;
			else
				dbservice.IsDeactive = true;

			await _db.SaveChangesAsync();
			return RedirectToAction("Index");
		}
	}
}
