using KOPPEE.DAL;
using KOPPEE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading.Tasks;

namespace KOPPEE.ViewComponents
{
    public class AboutViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;

        public AboutViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            About about = await _db.About.FirstOrDefaultAsync();

            return View(about);
        }
    }
}
