using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.WebUI.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
		public IActionResult Index ()
        {
            var values = bm.TGetListWithCategory();
			return View(values);
        }
        public IActionResult BlogReadAll (int id)
		{
            ViewBag.i = id;
            var values = bm.TGetBlogById(id);
			return View(values);
		}
	}
}
