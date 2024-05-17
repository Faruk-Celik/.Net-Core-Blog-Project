using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.WebUI.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());
		public IActionResult Index ()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult PartialAddComment ()
		{
			return PartialView();
		}
		[HttpPost]
		public IActionResult PartialAddComment ( Comment p )
		{
			p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.CommentStatus = true;
			p.BlogID = 2;
			cm.TAddComment(p);
			return RedirectToAction("Index" , "Blog");
			//return RedirectToAction("Index", "Blog");
		}
		public PartialViewResult CommentListByBlog (int id)
		{
			var values =cm.TListAllComment(id);
			return PartialView(values);
		}

	}
}
