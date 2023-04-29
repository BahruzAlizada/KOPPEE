using KOPPEE.DAL;
using KOPPEE.Models;
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
			Offer offer = await _db.Offer.FirstOrDefaultAsync();
			return View(offer);
		}

		public async Task<IActionResult> Create()
		{
			return View();
		}

		
		public IActionResult Error()
		{
			return View();
		}
	}
}
