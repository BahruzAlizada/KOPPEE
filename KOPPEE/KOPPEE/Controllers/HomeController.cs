using KOPPEE.DAL;
using KOPPEE.ViewsModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace KOPPEE.Controllers
{
	public class HomeController : Controller
	{
		private readonly AppDbContext _db;

        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
		{
			HomeVM homeVM = new HomeVM
			{
				Products = await _db.Products.ToListAsync(),
				Categories = await _db.Categories.ToListAsync()
			};
			return View(homeVM);
		}

		

		
		public IActionResult Error()
		{
			return View();
		}
	}
}
