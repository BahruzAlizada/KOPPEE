using Microsoft.AspNetCore.Mvc;

namespace KOPPEE.Controllers
{
	public class HomeController : Controller
	{	
        public IActionResult Index()
		{
			return View();
		}

		

		
		public IActionResult Error()
		{
			return View();
		}
	}
}
