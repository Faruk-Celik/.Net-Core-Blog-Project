using Microsoft.AspNetCore.Mvc;

namespace CoreProject.WebUI.Controllers
{
	public class DefaultController : Controller
	{
		public PartialViewResult _PartialHead ()
		{
			return PartialView();
		}
		public PartialViewResult _PartialNavbar ()
		{
			return PartialView();
		}
		public PartialViewResult _PartialTopbar ()
		{
			return PartialView();
		}
		public PartialViewResult _PartialFooter ()
		{
			return PartialView();
		}
	}
}
