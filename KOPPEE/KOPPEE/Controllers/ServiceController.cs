using Microsoft.AspNetCore.Mvc;

namespace KOPPEE.Controllers
{
	public class ServiceController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
