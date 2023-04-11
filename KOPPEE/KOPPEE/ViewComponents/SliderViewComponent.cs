using KOPPEE.DAL;
using KOPPEE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KOPPEE.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;

        public SliderViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Slider> sliders = await _db.Sliders.Where(x => !x.IsDeactive).OrderByDescending(x=>x.Id).ToListAsync();

            return View(sliders);
        }
    }
}
