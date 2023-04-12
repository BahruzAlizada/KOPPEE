using KOPPEE.DAL;
using KOPPEE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace KOPPEE.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;

        public FooterViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Bio bio = await _db.Bio.FirstOrDefaultAsync();

            return View(bio);
        }
    }
}
