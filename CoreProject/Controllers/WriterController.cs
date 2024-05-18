using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.WebUI.Controllers
{
	
	public class WriterController : Controller
	{
		
		public IActionResult Index ()
		{
			
			return View();
		}
		public IActionResult WriterProfile ()
		{
			return View();
		}
		
		public IActionResult WriterMail ()
		{
			return View();
		}
		[AllowAnonymous]
		public IActionResult Test ()
		{
			return View();
		}
        [AllowAnonymous]
        public IActionResult WriterNavbarPartial ()
		{
			return PartialView();
		}
        [AllowAnonymous]
        public IActionResult WriterFooterPartial ()
		{
			return PartialView();
		}
     
	}
	
}
