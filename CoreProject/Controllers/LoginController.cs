using Microsoft.AspNetCore.Mvc;

namespace CoreProject.WebUI.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index ()
		{
			return View();
		}
	}
}
