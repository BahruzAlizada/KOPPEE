using Microsoft.AspNetCore.Mvc;

namespace KOPPEE.Controllers
{
	public class ReservationController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
