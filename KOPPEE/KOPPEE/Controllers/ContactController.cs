using Microsoft.AspNetCore.Mvc;

namespace KOPPEE.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
