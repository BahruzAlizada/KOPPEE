using KOPPEE.DAL;
using KOPPEE.Helper;
using KOPPEE.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KOPPEE.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SlidersController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        public SlidersController(AppDbContext db,IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _db.Sliders.ToListAsync();
            return View(sliders);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Slider slider)
        {
            if (slider.Title == null)
            {
                ModelState.AddModelError("Title", "Title can not be null");
                return View();
            }

            #region PhotoSave
            if (slider.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo can not be null");
                return View();
            }

            if (!slider.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Selecet Image Type");
                return View();
            }

            if (slider.Photo.IsOlder216Kb())
            {
                ModelState.AddModelError("Photo", "Max 216Kb");
                return View();
            }

            string folder = Path.Combine(_env.WebRootPath, "img");
            slider.Image = await slider.Photo.SaveFileAsync(folder);
            #endregion

            await _db.Sliders.AddAsync(slider);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Slider dbslider = await _db.Sliders.FirstOrDefaultAsync(x => x.Id == id);
            if (dbslider == null)
            {
                return BadRequest();
            }

            return View(dbslider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id,Slider slider)
        {
            if (id == null)
            {
                return NotFound();
            }
            Slider dbslider = await _db.Sliders.FirstOrDefaultAsync(x => x.Id == id);
            if (dbslider == null)
            {
                return BadRequest();
            }

            #region PhotoSave
            if (slider.Photo != null)
            {
                if (!slider.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Selecet Image Type");
                    return View();
                }

                if (slider.Photo.IsOlder216Kb())
                {
                    ModelState.AddModelError("Photo", "Max 216Kb");
                    return View();
                }

                string folder = Path.Combine(_env.WebRootPath, "img");
                slider.Image = await slider.Photo.SaveFileAsync(folder);
                string path = Path.Combine(_env.WebRootPath, "img",dbslider.Image);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                
                dbslider.Image = slider.Image;
            }
            #endregion

            dbslider.Title = slider.Title;
            dbslider.Description = slider.Description;

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Slider dbslider = await _db.Sliders.FirstOrDefaultAsync(x => x.Id == id);
            if (dbslider == null)
            {
                return BadRequest();
            }

            return View(dbslider);
        }

        public async Task<IActionResult> Activity(int? id)
        {
            if (id == null)
            {
                NotFound();
            }
            Slider dbslider = await _db.Sliders.FirstOrDefaultAsync(x => x.Id == id);
            if (dbslider == null)
            {
                return BadRequest();
            }

            if(dbslider.IsDeactive)
            {
                dbslider.IsDeactive = false;
            }
            else
            {
                dbslider.IsDeactive = true;
            }

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}
