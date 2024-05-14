using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
		public PartialViewResult PartialAddComment ()
		{
			return PartialView();
		}
		public PartialViewResult CommentListByBlog (int id)
		{
			var values =cm.TListAllComment(id);
			return PartialView(values);
		}

	}
}
