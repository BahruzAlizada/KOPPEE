using Microsoft.AspNetCore.Mvc;

namespace KOPPEE.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
