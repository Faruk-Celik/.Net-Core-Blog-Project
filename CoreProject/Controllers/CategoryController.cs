using Microsoft.AspNetCore.Mvc;

namespace CoreProject.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index ()
        {
            return View();
        }
    }
}
