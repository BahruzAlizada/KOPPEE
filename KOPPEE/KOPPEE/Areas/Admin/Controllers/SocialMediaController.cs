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
    public class SocialMediaController : Controller
    {
        private readonly AppDbContext _db;

        public SocialMediaController(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            List<SocialMedia> socials = await _db.SocialMedia.ToListAsync();
            return View(socials);
        }

        #region Update
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return NotFound();
            SocialMedia dbsocials = await _db.SocialMedia.FirstOrDefaultAsync(x => x.Id == id);
            if (dbsocials == null)
                return BadRequest();

            return View(dbsocials);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id, SocialMedia socials)
        {
            if (id == null)
                return NotFound();
            SocialMedia dbsocials = await _db.SocialMedia.FirstOrDefaultAsync(x => x.Id == id);
            if (dbsocials == null)
                return BadRequest();

            dbsocials.Instagram = socials.Instagram;
            dbsocials.Facebook = socials.Facebook;
            dbsocials.Twitter = socials.Twitter;
            dbsocials.Linkedin = socials.Linkedin;

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        #endregion

    }
}
