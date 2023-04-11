using Microsoft.AspNetCore.Mvc;

namespace KOPPEE.Controllers
{
	public class MenuController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
