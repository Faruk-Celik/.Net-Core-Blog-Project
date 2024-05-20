using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class DashboardController : Controller
    {
        
        public IActionResult Index ()
        {
            return View();
        }
    }
}
