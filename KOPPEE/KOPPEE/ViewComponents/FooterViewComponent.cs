using KOPPEE.DAL;
using KOPPEE.Models;
using KOPPEE.ViewsModel.FooterVM;
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
            FooterVM footerVM = new FooterVM
            {
                Bio = await _db.Bio.FirstOrDefaultAsync(),
                SocialMedia = await _db.SocialMedia.FirstOrDefaultAsync()
            };

            return View(footerVM);
        }
    }
}
