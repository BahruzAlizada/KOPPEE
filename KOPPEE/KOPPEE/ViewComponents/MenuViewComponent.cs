using KOPPEE.DAL;
using KOPPEE.ViewsModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading.Tasks;

namespace KOPPEE.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;

        public MenuViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            HomeVM homeVM = new HomeVM
            {
                Categories =  await _db.Categories.ToListAsync(),
                Products = await _db.Products.ToListAsync()
            };

            return View(homeVM);
        }
    }
}
