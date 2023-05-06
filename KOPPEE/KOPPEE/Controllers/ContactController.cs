using KOPPEE.DAL;
using KOPPEE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace KOPPEE.Controllers
{
	public class ContactController : Controller
	{
		private readonly AppDbContext _db;

        public ContactController(AppDbContext db)
        {
			_db = db;
        }

        public async Task<IActionResult> Index()
		{
			Bio bio = await _db.Bio.FirstOrDefaultAsync();
			
			return View(bio);
		}
	}
}
