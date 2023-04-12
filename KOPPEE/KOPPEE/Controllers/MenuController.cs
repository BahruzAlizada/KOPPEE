using KOPPEE.DAL;
using KOPPEE.ViewsModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

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
